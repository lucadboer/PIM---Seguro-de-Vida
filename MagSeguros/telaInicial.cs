using Npgsql;

namespace MagSeguros
{
    public partial class MagTelaInicial : Form
    {
        public MagTelaInicial()
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
            string namess = Convert.ToString(txbUsuario);

        }

        private void bttEntrar_Click(object sender, EventArgs e)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();

           // NpgsqlConnection cmd = new NpgsqlConnection(connString);

            // realizar querys

            String usuario = txbUsuario.Text;
            String senha = txbSenha.Text;
            
            //MessageBox.Show("Login");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}