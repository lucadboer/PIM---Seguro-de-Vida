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
    public partial class Tela_procurarCadastro : Form
    {
        public Tela_procurarCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqlcnt = "Host=localhost;Database=teste01;Username=postgres;Password=dbadmin";
            NpgsqlConnection con = new NpgsqlConnection(sqlcnt);
            con.Open();
            String sql = "select * from tb_cadastro where cpf = "+txt_consulta_cpf.Text;

            NpgsqlCommand teste0 = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = teste0.ExecuteReader();

          /*  while(reader.Read())
            {
                dataGridView1.Columns.Item

                reader.GetValue(1);
            }
          */

            



            con.Close();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tela_escolha tela_Escolha = new Tela_escolha();
            tela_Escolha.Show();
            this.Hide();
        }
    }
}
