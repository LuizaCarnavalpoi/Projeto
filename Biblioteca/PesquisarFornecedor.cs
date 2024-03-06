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
    public partial class PesquisarFornecedor : Form
    {
        public PesquisarFornecedor()
        {
            InitializeComponent();
        }

        private void PesquisarFornecedor_Load(object sender, EventArgs e)
        {
            dgvFornecedor.Hide();
            btnAlterarForn.Hide();
            btn_deletarForn.Hide();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void txtFornCNPJ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvFornecedor.Show();
                Conexao.Conectar();
                string sql = "select * from biblioteca.fornecedor WHERE fornec_CNPJ LIKE '" + txtFornCNPJ.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                // DataTable - Cópia da tabela para memória
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvFornecedor.DataSource = dt;
                if (txtFornCNPJ.Text.Trim().Length == 0)
                {
                    dt.Reset();
                    dgvFornecedor.Hide();
                    btnAlterarForn.Hide();
                    btn_deletarForn.Hide();
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

        private void btn_deletarForn_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvFornecedor.SelectedRows[0];
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
                        DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja deletar o cadastro do(a) fornecedor(a): " + dgvFornecedor.CurrentRow.Cells[1].Value.ToString() + "?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                Conexao.Conectar();
                                string sql = @"DELETE FROM biblioteca.fornecedor WHERE fornec_CNPJ = @CODIGO";
                                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                                cmd.Parameters.AddWithValue("CODIGO", dgvFornecedor.CurrentRow.Cells[0].Value);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Cliente deletado do banco de dados com sucesso!");
                                txtFornCNPJ.Clear();
                                txtFornCNPJ.Focus();
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

        private void btnAlterarForn_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvFornecedor.SelectedRows[0];
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
                        PesquisarFornecedor form2 = new PesquisarFornecedor();
                        this.Hide();
                       form2.Hide();
                       form2.mskCNPJ.Text = dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
                       form2.txt_nomeForn.Text = dgvFornecedor.CurrentRow.Cells[1].Value.ToString();
                       form2.msk_CelForn.Text = dgvFornecedor.CurrentRow.Cells[2].Value.ToString();
                       form2.txt_emailForn.Text = dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
                       form2.mskCEPForn.Text = dgvFornecedor.CurrentRow.Cells[4].Value.ToString();
                       form2.cmb_estadoForn.Text = dgvFornecedor.CurrentRow.Cells[5].Value.ToString();
                       form2.cmb_cidadeForn.Text = dgvFornecedor.CurrentRow.Cells[6].Value.ToString();
                       form2.txt_ruaForn.Text = dgvFornecedor.CurrentRow.Cells[7].Value.ToString();
                       form2.txt_NumeroForn.Text = dgvFornecedor.CurrentRow.Cells[8].Value.ToString();
                       form2.txt_complementoForn.Text = dgvFornecedor.CurrentRow.Cells[9].Value.ToString();
                       form2.txt_bairroForn.Text = dgvFornecedor.CurrentRow.Cells[10].Value.ToString();
                       form2.btn_cadastrar.Hide();
                       form2.mskCNPJ.ReadOnly = true;
                       form2.label14.Text = "Alterar Cadastro";
                       form2.Text = "Tela de Alteração";
                       form2.ShowDialog();
                    }
                }
            }
        }

        private void dgvFornecedor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAlterarForn.Show();
            btn_deletarForn.Show();
        }
    }
}
