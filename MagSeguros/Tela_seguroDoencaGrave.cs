using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagSeguros
{
    public partial class Tela_seguroDoencaGrave : Form
    {
        public Tela_seguroDoencaGrave()
        {
            InitializeComponent();
        }

        Pessoa pessoa = new Pessoa();

        private void button1_Click_2(object sender, EventArgs e)
        {
            pessoa.parcela = Pessoa.Idade / 3.7;
            label12.Text = "A parcela do cliente será de R$ " + pessoa.parcela.ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pessoa.parcela = (Pessoa.Idade / 3.7) * 2;
            label12.Text = "A parcela do cliente será de R$ " + pessoa.parcela.ToString("F2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pessoa.parcela = (Pessoa.Idade / 3.7) * 3;
            label12.Text = "A parcela do cliente será de R$ " + pessoa.parcela.ToString("F2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tela_seguro tela_Seguro = new Tela_seguro();
            tela_Seguro.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pessoa.parcela != 0)
            {
                if (MessageBox.Show("Confirmar esse contrato?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    MessageBox.Show($"Contrato de R$ {pessoa.parcela.ToString("F2")} realizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"Ainda nenhum plano foi selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
