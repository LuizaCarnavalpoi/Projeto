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
    public partial class PesquisarLivro : Form
    {
        public PesquisarLivro()
        {
            InitializeComponent();
        }

        private void PesquisarLivro_Load(object sender, EventArgs e)
        {
            dgvLivros.Hide();
            btnAlterar.Hide();
            btn_deletarLivro.Hide();
        }

        private void txtLivroISBN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvLivros.Show();
                Conexao.Conectar();
                string sql = "select * from biblioteca.livro WHERE livro_ISBN LIKE '" + txtLivroISBN.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                // DataTable - Cópia da tabela para memória
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvLivros.DataSource = dt;
                if (txtLivroISBN.Text.Trim().Length == 0)
                {
                    dt.Reset();
                    dgvLivros.Hide();
                    btnAlterar.Hide();
                    btn_deletarLivro.Hide();
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

        private void btn_deletarLivro_Click(object sender, EventArgs e)
        {
            if (dgvLivros.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvLivros.SelectedRows[0];
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
                        DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja deletar o cadastro do livro: " + dgvLivros.CurrentRow.Cells[1].Value.ToString() + "?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                Conexao.Conectar();
                                string sql = @"DELETE FROM biblioteca.livro WHERE livro_ISBN = @CODIGO";
                                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                                cmd.Parameters.AddWithValue("CODIGO", dgvLivros.CurrentRow.Cells[0].Value);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Cliente deletado do banco de dados com sucesso!");
                                txtLivroISBN.Clear();
                                txtLivroISBN.Focus();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvLivros.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvLivros.SelectedRows[0];
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
                        TelaCadastroLivro form2 = new TelaCadastroLivro();
                        this.Hide();
                        form2.Hide();
                        form2.mskISBN.Text = dgvLivros.CurrentRow.Cells[0].Value.ToString();
                        form2.txt_nomeLivro.Text = dgvLivros.CurrentRow.Cells[1].Value.ToString();
                        form2.txtAutor.Text = dgvLivros.CurrentRow.Cells[2].Value.ToString();
                        form2.mskAnoPub.Text = dgvLivros.CurrentRow.Cells[3].Value.ToString().Substring(0, 10);
                        form2.txtDesc.Text = dgvLivros.CurrentRow.Cells[4].Value.ToString();
                        form2.txtGenero.Text = dgvLivros.CurrentRow.Cells[5].Value.ToString();
                        form2.txtQuant.Text = dgvLivros.CurrentRow.Cells[6].Value.ToString();
                        form2.mskDataEnt.Text = dgvLivros.CurrentRow.Cells[7].Value.ToString().Substring(0, 10);
                        form2.cmbCNPJ.Text = dgvLivros.CurrentRow.Cells[8].Value.ToString();
                        form2.btn_cadastrar.Hide();
                        form2.mskISBN.ReadOnly = true;
                        form2.label14.Text = "Alterar Cadastro";
                        form2.Text = "Tela de Alteração";
                        form2.ShowDialog();
                    }
                }
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void dgvLivros_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAlterar.Show();
            btn_deletarLivro.Show();
        }
    }
}