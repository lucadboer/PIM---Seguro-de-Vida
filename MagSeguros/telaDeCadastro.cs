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
using System.Data.SqlClient;

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
            txtCPF.Text = maskedTextBox1.Text;
            txtTelefone.Text = maskedTextBox2.Text;


            if (txtNome.Text == "" || txtCPF.Text == "" || txtIdade.Text == ""
                && txtGenero.Text == "" || txtEstadoCivil.Text == "" || txtRenda.Text == "" || txtOcupacaoAtual.Text == "" || comboDoença.Text != "Sim" && comboDoença.Text != "Não")
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int aux = Convert.ToInt32(txtIdade.Text);
                    if (aux is int)
                    {
                        String sqlcnt = "Host=localhost;Port=2526;Database=teste_pim;Username=postgres;Password=252601";

                        NpgsqlConnection postgre_cnt = new NpgsqlConnection(sqlcnt);
                        postgre_cnt.Open();

                        String sql = "insert into tb_cadastro (nome, cpf, idade, genero, estadocivil, telefone, renda, ocupacaoatual) values ('" + txtNome.Text + "','" + txtCPF.Text + "','" + txtIdade.Text + "','" + txtGenero.Text + "','" + txtEstadoCivil.Text + "','" + txtTelefone.Text + "','" + txtRenda.Text + "','" + txtOcupacaoAtual.Text + "')";

                        NpgsqlCommand postgre_cmd = new NpgsqlCommand(sql, postgre_cnt);

                        postgre_cmd.ExecuteNonQuery();
                        postgre_cnt.Close();


                        Pessoa.Idade = Convert.ToInt32(txtIdade.Text);

                        MessageBox.Show("Cadastrado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Tela_seguro tela_Seguro = new Tela_seguro();
                        tela_Seguro.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("A idade precisa ser um número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show("CPF já cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                // Pessoa.CPF = txtCPF.Text;
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtCPF.Clear();
            txtGenero.Clear();
            txtEstadoCivil.Clear();
            txtTelefone.Clear();
            txtRenda.Clear();
            txtOcupacaoAtual.Clear();
           // comboDoença.();
            txtNome.Focus();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
    }
}
