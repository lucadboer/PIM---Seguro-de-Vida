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
            txt_consulta_cpf.Text = maskedTextBox1.Text;

            try
            {
                String sqlcnt = "Host=localhost;Port=5432;Database=teste_pim;Username=postgres;Password=686798";
                NpgsqlConnection postgre_cnt = new NpgsqlConnection(sqlcnt);
                postgre_cnt.Open();
                String sql = "select nome, idade, genero, estadocivil, telefone, renda, ocupacaoatual from tb_cadastro where cpf = ('" + txt_consulta_cpf.Text + "')";

                NpgsqlCommand postgre_cmd = new NpgsqlCommand(sql, postgre_cnt);

                //executa o reader (leitor de dados)
                NpgsqlDataReader reader = postgre_cmd.ExecuteReader();

                reader.Read();
                //if (reader.Read()) /// coloca o reader dentro do if
                //{
                    txtNome.Text = reader.GetString(0);
                    txtIdade.Text = reader.GetValue(1).ToString();
                    txtGenero.Text = reader.GetString(2);
                    txtEstadoCivil.Text = reader.GetString(3);
                    txtTelefone.Text = reader.GetString(4);
                    txtRenda.Text = reader.GetString(5);
                    txtOcupacaoAtual.Text = reader.GetString(6);
               // }

                /*else
                {
                    MessageBox.Show("Test");
                }*/
                
                postgre_cnt.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Cadastro não encontrado" + erro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tela_escolha tela_Escolha = new Tela_escolha();
            tela_Escolha.Show();
            this.Hide();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlcnt = "Host=localhost;Database=teste01;Username=postgres;Password=dbadmin";

                NpgsqlConnection postgre_cnt = new NpgsqlConnection(sqlcnt);
                postgre_cnt.Open();

                NpgsqlCommand postgre_cmd = new NpgsqlCommand("delete from tb_cadastro where cpf = " + txt_consulta_cpf, postgre_cnt);

                postgre_cmd.ExecuteNonQuery();
                MessageBox.Show("Registro removido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                postgre_cnt.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível deletar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txt_consulta_cpf.Text = maskedTextBox1.Text;
        }
    }
}
