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
        private void button1_Click_2(object sender, EventArgs e)
        {
            double parcela = Pessoa.Idade / 3.7;
            label12.Text = "A parcela do cliente será de R$ " + parcela.ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double parcela = (Pessoa.Idade / 3.7) * 2;
            label12.Text = "A parcela do cliente será de R$ " + parcela.ToString("F2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double parcela = (Pessoa.Idade / 3.7) * 3;
            label12.Text = "A parcela do cliente será de R$ " + parcela.ToString("F2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tela_seguro tela_Seguro = new Tela_seguro();
            tela_Seguro.Show();
            this.Hide();
        }
    }
}
