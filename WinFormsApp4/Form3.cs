using System.Data.OleDb;
using System.Net.Http;
using System.Text.Json;
using Zenit;

namespace WinFormsApp4
{
    public partial class Form3 : Form
    {
        private static readonly HttpClient _http = new HttpClient();
        private const string OPENWEATHER_KEY = "A_TUA_KEY_AQUI";
        private const string NEWSAPI_KEY = "A_TUA_KEY_AQUI";

        public Form3()
        {
            InitializeComponent();
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            await Task.WhenAll(
                CarregarClimaAsync(),
                CarregarProjetosAsync(),
                CarregarFeriadosAsync()
            );
        }

        // ── API 1: OpenWeatherMap ─────────────────────────────────────────────
        private async Task CarregarClimaAsync()
        {
            try
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather" +
                             $"?q=Lisboa&appid={OPENWEATHER_KEY}&units=metric&lang=pt";

                string json = await _http.GetStringAsync(url);
                using var doc = JsonDocument.Parse(json);
                var root = doc.RootElement;

                string descricao = root.GetProperty("weather")[0].GetProperty("description").GetString();
                double temp = root.GetProperty("main").GetProperty("temp").GetDouble();
                double sensacao = root.GetProperty("main").GetProperty("feels_like").GetDouble();
                int humidade = root.GetProperty("main").GetProperty("humidity").GetInt32();
                double vento = root.GetProperty("wind").GetProperty("speed").GetDouble();

                listBox1.Invoke(() =>
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"Lisboa");
                    listBox1.Items.Add($"{temp:F1}°C — {descricao}");
                    listBox1.Items.Add($"Sensação: {sensacao:F1}°C");
                    listBox1.Items.Add($"Humidade: {humidade}%");
                    listBox1.Items.Add($"Vento: {vento} m/s");
                });
            }
            catch
            {
                listBox1.Invoke(() =>
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Sem ligação");
                });
            }
        }

        // ── BD Local: Projetos do utilizador ─────────────────────────────────
        private async Task CarregarProjetosAsync()
        {
            await Task.Run(() =>
            {
                try
                {
                    using var conn = DatabaseHelper.GetConnection();
                    conn.Open();

                    string sql = "SELECT Nome, Estado FROM Projetos WHERE UtilizadorId=? ORDER BY DataCriacao DESC";
                    using var cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("?", SessaoAtual.UserId);
                    using var reader = cmd.ExecuteReader();

                    var items = new List<string>();
                    while (reader.Read())
                    {
                        string nome = reader["Nome"].ToString();
                        string estado = reader["Estado"].ToString();
                        items.Add($"[{estado}] {nome}");
                    }

                    listBox2.Invoke(() =>
                    {
                        listBox2.Items.Clear();
                        if (items.Count == 0)
                            listBox2.Items.Add("Sem projetos");
                        else
                            items.ForEach(i => listBox2.Items.Add(i));
                    });
                }
                catch
                {
                    listBox2.Invoke(() =>
                    {
                        listBox2.Items.Clear();
                        listBox2.Items.Add("Erro ao carregar projetos");
                    });
                }
            });
        }

        // ── API 2: Nager.Date — Feriados PT ──────────────────────────────────
        private async Task CarregarFeriadosAsync()
        {
            try
            {
                int ano = DateTime.Now.Year;
                string url = $"https://date.nager.at/api/v3/PublicHolidays/{ano}/PT";

                string json = await _http.GetStringAsync(url);
                using var doc = JsonDocument.Parse(json);
                var hoje = DateTime.Today;

                listBox3.Invoke(() =>
                {
                    listBox3.Items.Clear();
                    int count = 0;
                    foreach (var item in doc.RootElement.EnumerateArray())
                    {
                        DateTime data = DateTime.Parse(item.GetProperty("date").GetString());
                        if (data < hoje) continue;

                        string nome = item.GetProperty("localName").GetString();
                        int diasAte = (data - hoje).Days;
                        string entrada = diasAte == 0
                            ? $"HOJE — {nome}"
                            : $"{data:dd/MM} — {nome} ({diasAte}d)";

                        listBox3.Items.Add(entrada);
                        if (++count == 6) break;
                    }

                    if (listBox3.Items.Count == 0)
                        listBox3.Items.Add("Sem feriados próximos");
                });
            }
            catch
            {
                listBox3.Invoke(() =>
                {
                    listBox3.Items.Clear();
                    listBox3.Items.Add("Sem ligação");
                });
            }
        }

        // ── Navegação ─────────────────────────────────────────────────────────
        private void button1_Click(object sender, EventArgs e) // Kanban
        {
            new Form4().Show();
        }

        private void button2_Click(object sender, EventArgs e) // Tarefas
        {
            new Form5().Show();
        }

        private void button3_Click(object sender, EventArgs e) // Relatórios
        {
            new Form6().Show();
        }

        // ── Eventos sem lógica ────────────────────────────────────────────────
        private void label1_Click(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
