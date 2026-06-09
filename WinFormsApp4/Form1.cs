using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '●';
            label3.Cursor = Cursors.Hand;
            label4.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox2.Text.Trim();
            string senha = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preenche todos os campos.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hash = HashSHA256(senha);

            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                string sql = "SELECT Id, Username FROM Utilizadores WHERE Username=? AND Password=?";
                using var cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("?", usuario);
                cmd.Parameters.AddWithValue("?", hash);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    SessaoAtual.UserId = Convert.ToInt32(reader["Id"]);
                    SessaoAtual.Username = reader["Username"].ToString();

                    this.Hide();
                    var dashboard = new Form3();
                    dashboard.FormClosed += (s, args) => this.Close();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Utilizador ou senha incorretos.", "Erro de autenticação",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var registo = new Form2();
            registo.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para recuperar a senha, contacta o administrador.", "Recuperar Senha",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Reservado para validação futura (ex: verificar caracteres inválidos)
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Reservado para validação futura (ex: indicador de força de senha)
        }

        private static string HashSHA256(string input)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));
            return Convert.ToHexString(bytes);
        }
    }
}