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

                    if (txt_cd_nome.Text == "" || txt_cd_usuario.Text == "" || txt_cd_senha.Text == "" || txt_confirmar_senha.Text == "")
                    {
                        MessageBox.Show("Todos os campos precisam ser preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    else if (txt_cd_senha.Text.Length < 6)
                    {
                        MessageBox.Show("A senha precisa ser maior que 5 digitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        String sqlcnt = "Host=localhost;Port=2526;Database=teste_pim;Username=postgres;Password=252601";

                        NpgsqlConnection postgre_cnt = new NpgsqlConnection(sqlcnt);
                        postgre_cnt.Open();

                            String sql = "insert into tb_cadastro_funcionario (fun_usuario, fun_senha, fun_nome) values ('" + txt_cd_usuario.Text + "','" + txt_confirmar_senha.Text + "', '" + txt_cd_nome.Text + "')";

                            NpgsqlCommand postgre_cmd = new NpgsqlCommand(sql, postgre_cnt);

                            postgre_cmd.ExecuteNonQuery();
                            postgre_cnt.Close();
                            MessageBox.Show("Usuário cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();                      
      
                    }




                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível cadastrar" + erro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("As senhas estão diferentes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tela_cadastro_fun_Load(object sender, EventArgs e)
        {
            txt_cd_usuario.Clear();
            txt_cd_nome.Focus();
        }
    }
}
