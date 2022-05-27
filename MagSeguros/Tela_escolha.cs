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
    public partial class Tela_escolha : Form
    {
        public Tela_escolha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tela2_Load(object sender, EventArgs e)
        {
            entrada.Text = $"Olá {Pessoa.Usuario}, o que deseja fazer?";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaDeCadastro telaDeCadastro = new TelaDeCadastro();
            telaDeCadastro.Show();
            this.Hide();

        }

        private void btnProcurarCadastro_Click(object sender, EventArgs e)
        {
            Tela_procurarCadastro Tela_procurarCadastro = new Tela_procurarCadastro();
            Tela_procurarCadastro.Show();
            this.Hide();

        }

        private void entrada_Click(object sender, EventArgs e)
        {

        }

        private void sairDaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_login tela_Login = new Tela_login();
            tela_Login.Show();
            this.Hide();
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnListarCadastro_Click(object sender, EventArgs e)
        {
            Tela_listarCadastros tela_ListarCadastros = new Tela_listarCadastros();
            tela_ListarCadastros.Show();
            this.Hide();
        }
    }
}
