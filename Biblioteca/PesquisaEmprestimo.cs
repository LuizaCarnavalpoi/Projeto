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
    public partial class PesquisaEmprestimo : Form
    {
        public PesquisaEmprestimo()
        {
            InitializeComponent();
        }

        private void txtPesquisaEmp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvEmprestimo.Show();
                btn_concluirEmp.Hide();
                btnAlterar.Hide();
                Conexao.Conectar();
                string sql = "select * from pesquisarEmprestimo WHERE Emprestimo LIKE '" + txtPesquisaEmp.Text + "%'";
                if (btnEmprestados.BackColor == Color.Green)
                {
                    sql = "select * from pesquisarEmprestimo WHERE Emprestimo LIKE '" + txtPesquisaEmp.Text + "%' and Status = 'Emprestado'";
                }
                else if (btnConcluidos.BackColor == Color.Green)
                {
                    sql = "select * from pesquisarEmprestimo WHERE Emprestimo LIKE '" + txtPesquisaEmp.Text + "%' and Status = 'Concluido'";
                }
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                // DataTable - Cópia da tabela para memória
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvEmprestimo.DataSource = dt;
                if (txtPesquisaEmp.Text.Trim().Length == 0)
                {
                    dt.Reset();
                    dgvEmprestimo.Hide();
                    btnAlterar.Hide();
                    btn_concluirEmp.Hide();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvEmprestimo.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvEmprestimo.SelectedRows[0];
                if (currentRow.Cells.Count > 0)
                {
                    bool rowIsEmpty = true;

                    foreach (DataGridViewCell cell in currentRow.Cells)
                    {
                        if (cell.Value != null)
                        {
                            rowIsEmpty = false;
                            break;
                        }
                    }

                    if (rowIsEmpty)
                    {
                        MessageBox.Show("A coluna de dados selecionada esta vazia!");
                    }
                    else
                    {
                        FormCadastroEmprestimo form2 = new FormCadastroEmprestimo ();
                        this.Hide();

                          form2.btn_cadastrar.Hide();
                          form2.livroID = dgvEmprestimo.CurrentRow.Cells[0].Value.ToString();
                          form2.mskDataEmp.Text = dgvEmprestimo.CurrentRow.Cells[1].Value.ToString().Substring(0, 10);
                          form2.mskDataDev.Text = dgvEmprestimo.CurrentRow.Cells[2].Value.ToString().Substring(0, 10);
                          form2.cmbISBN.Text = dgvEmprestimo.CurrentRow.Cells[4].Value.ToString();
                          form2.cmbCPF.Text = dgvEmprestimo.CurrentRow.Cells[5].Value.ToString();
                          form2.txtTituloLivro.Text = dgvEmprestimo.CurrentRow.Cells[6].Value.ToString();
                          form2.cmbCPF.Enabled = false;
                          form2.cmbISBN.Enabled = false;
                          form2.mskDataEmp.Enabled = false;
                          form2.label14.Text = "Alterar Cadastro";
                          form2.Text = "Tela de Alteração";
                          form2.ShowDialog();
                    }
                }
            }
        }

        private void btn_concluirEmp_Click(object sender, EventArgs e)
        {
            if (dgvEmprestimo.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvEmprestimo.SelectedRows[0];
                if (currentRow.Cells.Count > 0)
                {
                    bool rowIsEmpty = true;

                    foreach (DataGridViewCell cell in currentRow.Cells)
                    {
                        if (cell.Value != null)
                        {
                            rowIsEmpty = false;
                            break;
                        }
                    }

                    if (rowIsEmpty)
                    {
                        MessageBox.Show("A coluna de dados selecionada esta vazia!");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("O livro do empréstimo: " + dgvEmprestimo.CurrentRow.Cells[0].Value.ToString() + " foi devolvido?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                Conexao.Conectar();
                                string sql = @"update biblioteca.emprestimo set emprestimo_STATUS = 'Concluido' WHERE emprestimo_ID = @CODIGO";
                                string sql2 = @"update biblioteca.livro set livro_quantidade = livro_quantidade + 1 where livro_ISBN = @isbn";
                                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                                cmd.Parameters.AddWithValue("CODIGO", dgvEmprestimo.CurrentRow.Cells[0].Value);
                                cmd.ExecuteNonQuery();

                                cmd = new SqlCommand(sql2, Conexao.conn);
                                cmd.Parameters.AddWithValue("isbn", dgvEmprestimo.CurrentRow.Cells[4].Value);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Sucesso!");
                                txtPesquisaEmp.Clear();
                                txtPesquisaEmp.Focus();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Error: " + ex.Message);
                            }
                            finally
                            {
                                Conexao.Fechar();
                            }
                        }
                    }
                }

            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void PesquisaEmprestimo_Load(object sender, EventArgs e)
        {
            dgvEmprestimo.Hide();
            btnAlterar.Hide();
            btn_concluirEmp.Hide();
        }

        private void dgvEmprestimo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEmprestados_Click(object sender, EventArgs e)
        {
            try
            {
                txtPesquisaEmp.Clear();
                txtPesquisaEmp.Focus();
                if (btnEmprestados.BackColor == Color.Red)
                {
                    btnEmprestados.BackColor = Color.Green;
                    btnConcluidos.BackColor = Color.Red;
                    btnEmprestados.ForeColor = Color.White;
                    btnConcluidos.ForeColor = Color.Black;
                }
                else
                {
                    btnEmprestados.BackColor = Color.Red;
                    btnEmprestados.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        private void btnConcluidos_Click(object sender, EventArgs e)
        {
            try
            {
                txtPesquisaEmp.Clear();
                txtPesquisaEmp.Focus();
                if (btnConcluidos.BackColor == Color.Red)
                {
                    btnConcluidos.BackColor = Color.Green;
                    btnEmprestados.BackColor = Color.Red;
                    btnConcluidos.ForeColor = Color.White;
                    btnEmprestados.ForeColor = Color.Black;
                }
                else
                {
                    btnConcluidos.BackColor = Color.Red;
                    btnConcluidos.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        private void dgvEmprestimo_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmprestimo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvEmprestimo.CurrentRow.Cells[3].Value.ToString() == "Emprestado")
                {
                    btnAlterar.Show();
                    btn_concluirEmp.Show();
                }
                else
                {
                    btnAlterar.Hide();
                    btn_concluirEmp.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }
        }
    }
}