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
    public partial class PesquisarCliente : Form
    {
        public PesquisarCliente()
        {
            InitializeComponent();
        }

        private void PesquisarCliente_Load(object sender, EventArgs e)
        {
            dgvClientes.Hide();
            btnAlterar.Hide();
            btn_deletarClie.Hide();

        }

        private void txtNomeLeitor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvClientes.Show();
                Conexao.Conectar();
                string sql = "select * from biblioteca.clientes WHERE client_CPF LIKE '" + txtClienteCPF.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                // DataTable - Cópia da tabela para memória
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvClientes.DataSource = dt;
                if (txtClienteCPF.Text.Trim().Length == 0)
                {
                    dt.Reset();
                    dgvClientes.Hide();
                    btnAlterar.Hide();
                    btn_deletarClie.Hide();
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



        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvClientes.SelectedRows[0];
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
                        DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja deletar o cadastro do(a) cliente: " + dgvClientes.CurrentRow.Cells[1].Value.ToString() + "?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                Conexao.Conectar();
                                string sql = @"DELETE FROM biblioteca.clientes WHERE client_CPF = @CODIGO";
                                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                                cmd.Parameters.AddWithValue("CODIGO", dgvClientes.CurrentRow.Cells[0].Value);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Cliente deletado do banco de dados com sucesso!");
                                txtClienteCPF.Clear();
                                txtClienteCPF.Focus();
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
            else
            {
                MessageBox.Show("Selecione uma coluna a ser deletada!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvClientes.SelectedRows[0];
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
                        FormCadastroClientes form2 = new FormCadastroClientes();
                        this.Hide();
                        form2.btn_cadastrar.Hide();
                        form2.mskCPF.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                        form2.txt_nomeCli.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                        form2.msk_CelCli.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                        form2.txt_emailCli.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                        form2.mskDataNasc.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString().Substring(0, 10);
                        form2.mskCEPCli.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
                        form2.cmb_cidadeCli.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
                        form2.cmb_estadoCli.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
                        form2.txt_ruaCli.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
                        form2.txt_NumeroCli.Text = dgvClientes.CurrentRow.Cells[9].Value.ToString();
                        form2.txt_complementoCli.Text = dgvClientes.CurrentRow.Cells[10].Value.ToString();
                        form2.txt_bairroCli.Text = dgvClientes.CurrentRow.Cells[11].Value.ToString();
                        form2.mskCPF.ReadOnly = true;
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

        private void dgvClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAlterar.Show();
            btn_deletarClie.Show();
        }
    }
}