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

          

            if (txbSenha.Text == "" & txbUsuario.Text == "")
            {
                MessageBox.Show("Digite o seu usuário e senha para logar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txbUsuario.Text == "")
            {
                MessageBox.Show("Você não digitou o seu usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txbSenha.Text == "")
            {
                MessageBox.Show("Você não digitou a sua senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            if (txbUsuario.Text != "" && txbSenha.Text != "")
            {
                try
                {
                    String sqlcnt = "Host=localhost;Port=5432;Database=teste_pim;Username=postgres;Password=686798";

                    NpgsqlConnection postgre_cnt = new NpgsqlConnection(sqlcnt);
                    postgre_cnt.Open();

                    String sql = "select fun_usuario, fun_senha, fun_nome from tb_cadastro_funcionario where fun_usuario = ('" + txbUsuario.Text + "') and fun_senha = ('" + txbSenha.Text + "')";

                    NpgsqlCommand postgre_cmd = new NpgsqlCommand(sql, postgre_cnt);

                    NpgsqlDataReader reader = postgre_cmd.ExecuteReader();

                    reader.Read();
                    //if (reader.Read()) /// coloca o reader dentro do if
                    //{
                    string usu = reader.GetString(0);
                    string senha = reader.GetString(1);
                    string nome = reader.GetString(2);

                    Pessoa.Nome_Usuario = nome;

                    postgre_cnt.Close();

                    if (usu == txbUsuario.Text && senha == txbSenha.Text)
                    {
                        Tela_escolha tela_Escolha = new Tela_escolha();
                        tela_Escolha.Show();
                        this.Hide();
                    }
        
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
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

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            tela_cadastro_fun tela_Cadastro_Fun = new tela_cadastro_fun();
            tela_Cadastro_Fun.ShowDialog();

        }
    }
}