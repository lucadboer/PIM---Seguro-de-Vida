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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tela_seguro tela_Seguro = new Tela_seguro();
            tela_Seguro.Show();
            this.Hide();
        }
    }
}
