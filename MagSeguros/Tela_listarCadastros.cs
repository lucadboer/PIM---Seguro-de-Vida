using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace MagSeguros
{
    public partial class Tela_listarCadastros : Form
    {
        public Tela_listarCadastros()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tela_escolha tela_Escolha = new Tela_escolha();
            tela_Escolha.Show();
            this.Hide();
        }

        private void Tela_listarCadastros_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqlcnt = "Host=localhost;Port=2526;Database=teste_pim;Username=postgres;Password=252601";

            NpgsqlConnection postgre_cnt = new NpgsqlConnection(sqlcnt);
            postgre_cnt.Open();

            String sql = "select nome, cpf, idade, genero, estadocivil, telefone, renda, ocupacaoatual from tb_cadastro order by nome";

            NpgsqlCommand postgre_cmd = new NpgsqlCommand();

            postgre_cmd.Connection = postgre_cnt;
            postgre_cmd.CommandType = CommandType.Text;
            postgre_cmd.CommandText = sql;
            NpgsqlDataReader reader = postgre_cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            postgre_cnt.Close();
        }
    }
}
