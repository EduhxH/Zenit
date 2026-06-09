using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '●'; // senha
            textBox3.PasswordChar = '●'; // confirmar senha
            label3.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox2.Text.Trim();
            string senha = textBox1.Text.Trim();
            string confirma = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirma))
            {
                MessageBox.Show("Preenche todos os campos.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senha != confirma)
            {
                MessageBox.Show("As senhas não coincidem.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Clear();
                textBox3.Focus();
                return;
            }

            try
            {
                using var conn = DatabaseHelper.GetConnection();
                conn.Open();

                // Verifica se o username já existe
                string sqlCheck = "SELECT COUNT(*) FROM Utilizadores WHERE Username=?";
                using var cmdCheck = new OleDbCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("?", usuario);
                int existe = (int)cmdCheck.ExecuteScalar();

                if (existe > 0)
                {
                    MessageBox.Show("Este nome de utilizador já está em uso.", "Utilizador existente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }

                // Insere o novo utilizador
                string hash = HashSHA256(senha);
                string sqlInsert = "INSERT INTO Utilizadores (Username, Password, DataCriacao) VALUES (?, ?, ?)";
                using var cmdInsert = new OleDbCommand(sqlInsert, conn);
                cmdInsert.Parameters.AddWithValue("?", usuario);
                cmdInsert.Parameters.AddWithValue("?", hash);
                cmdInsert.Parameters.AddWithValue("?", DateTime.Now);
                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Conta criada com sucesso! Faz login.", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar conta:\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close(); // volta ao Form1 (Login)
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Reservado para validação futura
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Reservado para validação futura
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Reservado para validação futura
        }

        private static string HashSHA256(string input)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));
            return Convert.ToHexString(bytes);
        }
    }
}