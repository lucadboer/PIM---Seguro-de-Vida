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
    }
}
