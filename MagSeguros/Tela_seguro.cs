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
    public partial class Tela_seguro : Form
    {
        public Tela_seguro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_seguroVida tela_SeguroVida = new Tela_seguroVida();
            tela_SeguroVida.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tela_seguroDoencaGrave tela_SeguroDoencaGrave = new Tela_seguroDoencaGrave();
            tela_SeguroDoencaGrave.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaDeCadastro telaDeCadastro = new TelaDeCadastro();
            telaDeCadastro.Show();
            this.Hide();
        }
    }
}
