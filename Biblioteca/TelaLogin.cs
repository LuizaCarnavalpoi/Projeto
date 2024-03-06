using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Biblioteca
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
           
        }

       
        private void licensing1_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        Conexao.Conectar();
                        string sql = @"select * from biblioteca.funcionarios where func_LOGIN = @usuario
        and func_SENHA  = @senha ";

                        SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

                        cmd.Parameters.AddWithValue("usuario", txtLogin.Text);
                        cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                        //Verificar se Houve retorno de algum registro
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            MessageBox.Show("Login efetuado com sucesso!");
                            FormMenu menu = new FormMenu();
                            cmd.Parameters.AddWithValue("usuario", txtLogin.Text);

                            //Abrir o sistema - LOGIN EFETUADO
                            if (dr["func_CARGO"].ToString() == "ADMIN")
                            {
                                Visible = false;
                                menu.ShowDialog();
                                Visible = true;
                                txtLogin.Clear();
                                txtSenha.Clear();
                                txtLogin.Focus();
                            }
                            else if (dr["func_CARGO"].ToString() == "USER")
                            {
                                Visible = false;
                               // menu.funcionariosToolStripMenuItem.Visible = false;
                              //  menu.funcionariosToolStripMenuItem1.Visible = false;
                                menu.ShowDialog();
                                Visible = true;
                                txtLogin.Clear();
                                txtSenha.Clear();
                                txtLogin.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário e/ou senha inválidos!");
                        }

                        Conexao.Fechar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro:" + ex.Message);
                    }
                }

            }
        }

        private void txtSenha_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
