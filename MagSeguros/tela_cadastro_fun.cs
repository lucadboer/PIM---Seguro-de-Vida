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
    public partial class tela_cadastro_fun : Form
    {
        public tela_cadastro_fun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_confirmar_senha.Text == txt_cd_senha.Text)
            {
                try
                {
                    Pessoa.Fun_Usuario = txt_cd_usuario.Text;
                    Pessoa.Fun_Senha = txt_confirmar_senha.Text;
                    

                    String sqlcnt = "Host=localhost;Port=5432;Database=teste_pim;Username=postgres;Password=686798";

                    NpgsqlConnection postgre_cnt = new NpgsqlConnection(sqlcnt);
                    postgre_cnt.Open();

                    String sql = "insert into tb_cadastro_funcionario (fun_usuario, fun_senha) values ('" + txt_cd_usuario.Text + "','" + txt_confirmar_senha.Text + "')";

                    NpgsqlCommand postgre_cmd = new NpgsqlCommand(sql, postgre_cnt);

                    postgre_cmd.ExecuteNonQuery();
                    postgre_cnt.Close();
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar");
                }
            }
            else
            {
                MessageBox.Show("As senhas estão diferentes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
