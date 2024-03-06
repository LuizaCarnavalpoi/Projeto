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

namespace Biblioteca
{
    public partial class FormCadastroEmprestimo : Form
    {
        public FormCadastroEmprestimo()
        {
            InitializeComponent();
        }

        public string livroID { get; set; }
        private void TelaCadastroReserva_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "select * from biblioteca.clientes";
                string sql2 = "select * from biblioteca.livro";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                SqlDataAdapter da = new SqlDataAdapter(sql, Conexao.conn);
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, Conexao.conn);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    string cpf = string.Format("{0}", row.ItemArray[0]);
                    cmbCPF.Items.Add(cpf);
                }
                da2.Fill(dt2);
                foreach (DataRow row in dt2.Rows)
                {
                    string isbn = string.Format("{0}", row.ItemArray[0]);
                    cmbISBN.Items.Add(isbn);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (cmbCPF.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(cmbCPF, "Preencha o campo nome!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cmbCPF, "");
            }
            if (cmbISBN.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(cmbISBN, "Preencha o campo CPF!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cmbISBN, "");
            }
            try
            {
                Conexao.Conectar();
                string sql;
                sql = @"select livro_quantidade from biblioteca.livro where livro_ISBN = @isbn";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("isbn", cmbISBN.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                int quant = 0;
                if (rd.HasRows)
                {
                    rd.Read(); // read first row
                    quant = rd.GetInt32(0);
                    rd.Close();
                }

                if (quant > 0)
                {
                    sql = @"INSERT INTO biblioteca.emprestimo 
                        VALUES (@dataemp, @datadev, @status, @isbn, @cpf)";
                    string sql2 = @"update biblioteca.livro set livro_quantidade = livro_quantidade - 1 where livro_ISBN = @ISBN";
                    cmd = new SqlCommand(sql, Conexao.conn);

                    cmd.Parameters.AddWithValue("dataemp", mskDataEmp.Text);
                    cmd.Parameters.AddWithValue("datadev", mskDataDev.Text);
                    cmd.Parameters.AddWithValue("status", "Emprestado");
                    cmd.Parameters.AddWithValue("isbn", cmbISBN.Text);
                    cmd.Parameters.AddWithValue("cpf", cmbCPF.Text);
                    // Adicionar imagem NULL no banco de dados

                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(sql2, Conexao.conn);
                    cmd.Parameters.AddWithValue("isbn", cmbISBN.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Emprestimo cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Livro indisponível!");
                }
                Conexao.Fechar();


                //Utils.limparCampos(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAlterarRes_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE biblioteca.emprestimo SET 
                emprestimo_DataDevolucao = @data
                Where emprestimo_ID = @ID";

                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("ID", livroID);
                cmd.Parameters.AddWithValue("data", mskDataDev.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso");

                Conexao.Fechar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        private void cmbISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"select livro_TITULO from biblioteca.livro where livro_ISBN = @isbn";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("isbn", cmbISBN.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                string titulo = "";
                if (rd.HasRows)
                {
                    rd.Read(); // read first row
                    titulo = rd.GetString(0);
                    rd.Close();
                }
                txtTituloLivro.Text = titulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        private void FormCadastroEmprestimo_Load(object sender, EventArgs e)
        {

        }
    }
}

