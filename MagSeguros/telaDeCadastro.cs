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
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtEstadoCivil_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttCadastrar_Click(object sender, EventArgs e)
        {
            /*String sqlcnt = "Host=localhost;Database=teste01;Username=postgres;Password=dbadmin";
            NpgsqlConnection con = new NpgsqlConnection(sqlcnt);
            con.Open();
            String sql = "insert into tb_cadastro (nome, cpf) values ('"+txtNome.Text+"','"+txtCPF.Text+"','"+txtIdade.Text+ "','"+txtGenero.Text+ "','"+txtEstadoCivil.Text+ "','"+txtTelefone.Text+ "','"+txtRenda.Text+"','" + txtOcupacaoAtual.Text;

            NpgsqlCommand teste0 = new NpgsqlCommand(sql, con);
            teste0.ExecuteNonQuery();
            con.Close();*/

            Pessoa.Idade = Convert.ToInt32(txtIdade.Text);

            MessageBox.Show("Cadastrado com Sucesso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Tela_seguro tela_Seguro = new Tela_seguro();
            tela_Seguro.Show();
            this.Hide();

        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            Tela_escolha tela_Escolha = new Tela_escolha();
            tela_Escolha.Show();
            this.Hide();
        }

        public void txtIdade_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaDeCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
