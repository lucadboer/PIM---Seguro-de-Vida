using Npgsql;

namespace MagSeguros
{
    public partial class Tela_login : Form
    {
        public Tela_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bttEntrar_Click(object sender, EventArgs e)
        {

            //NpgsqlConnection conn = new NpgsqlConnection(connString);
            //conn.Open();

            // NpgsqlConnection cmd = new NpgsqlConnection(connString);

            // realizar querys

            //String usuario = txbUsuario.Text;
            //String senha = txbSenha.Text;

            //MessageBox.Show("Login");

            if (txbUsuario.Text == "")
            {
                MessageBox.Show("Você não digitou o seu usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (txbSenha.Text == "")
            {
                MessageBox.Show("Você não digitou a sua senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (txbUsuario.Text != "" && txbSenha.Text != "")
            {
                Pessoa.Usuario = txbUsuario.Text;
                Pessoa.Senha = txbSenha.Text;

                Tela_escolha tela_Escolha = new Tela_escolha();
                tela_Escolha.Show();
                this.Hide();
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void sairDoProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Tela_login_Load(object sender, EventArgs e)
        {

        }
    }
}