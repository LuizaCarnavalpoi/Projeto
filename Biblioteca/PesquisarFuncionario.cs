using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class PesquisarFuncionario : Form
    {
        public PesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void btnAlterarFunc_Click(object sender, EventArgs e)
        {
            if (dgvFuncionario.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvFuncionario.SelectedRows[0];
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
                    else if (dgvFuncionario.CurrentRow.Cells[7].Value.ToString() == Username.username)
                    {
                        MessageBox.Show("Você não pode alterar o funcionário no qual está logado!");
                    }
                    else
                    {
                        TelaCadastroFuncionario form2 = new TelaCadastroFuncionario();
                        this.Hide();
                        form2.Hide();
                        form2.mskCPF.Text = dgvFuncionario.CurrentRow.Cells[0].Value.ToString();
                        form2.txt_nomeFunc.Text = dgvFuncionario.CurrentRow.Cells[1].Value.ToString();
                        form2.msk_CelFunc.Text = dgvFuncionario.CurrentRow.Cells[2].Value.ToString();
                        form2.mskCEP.Text = dgvFuncionario.CurrentRow.Cells[3].Value.ToString();
                        form2.cmbCargo.Text = dgvFuncionario.CurrentRow.Cells[4].Value.ToString();
                        form2.txt_emailFunc.Text = dgvFuncionario.CurrentRow.Cells[5].Value.ToString();
                        form2.mskDataNasc.Text = dgvFuncionario.CurrentRow.Cells[6].Value.ToString().Substring(0, 10);
                        form2.txt_LoginFunc.Text = dgvFuncionario.CurrentRow.Cells[7].Value.ToString();
                        form2.txt_SenhaFunc.Text = dgvFuncionario.CurrentRow.Cells[8].Value.ToString();
                        form2.cmb_cidadeFunc.Text = dgvFuncionario.CurrentRow.Cells[9].Value.ToString();
                        form2.cmb_estadoFunc.Text = dgvFuncionario.CurrentRow.Cells[10].Value.ToString();
                        form2.txt_ruaFunc.Text = dgvFuncionario.CurrentRow.Cells[11].Value.ToString();
                        form2.txt_NumeroFunc.Text = dgvFuncionario.CurrentRow.Cells[12].Value.ToString();
                        form2.txt_complementoFunc.Text = dgvFuncionario.CurrentRow.Cells[13].Value.ToString();
                        form2.txt_bairroFunc.Text = dgvFuncionario.CurrentRow.Cells[14].Value.ToString();
                        form2.btn_cadastrar.Hide();
                        form2.mskCPF.ReadOnly = true;
                        form2.label14.Text = "Alterar Cadastro";
                        form2.Text = "Tela de Alteração";
                        form2.ShowDialog();
                    }
                }
            }
        }

        private void PesquisarFuncionario_Load(object sender, EventArgs e)
        {
            dgvFuncionario.Hide();
            btnAlterarFunc.Hide();
            btn_deletarFunc.Hide();
        }

        private void btn_deletarFunc_Click(object sender, EventArgs e)
        {
            if (dgvFuncionario.SelectedRows.Count > 0)
            {
                DataGridViewRow currentRow = dgvFuncionario.SelectedRows[0];
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
                    else if (dgvFuncionario.CurrentRow.Cells[7].Value.ToString() == Username.username)
                    {
                        MessageBox.Show("Você não pode alterar o funcionário no qual está logado!");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja deletar o cadastro do(a) funcionário(a): " + dgvFuncionario.CurrentRow.Cells[1].Value.ToString() + "?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                Conexao.Conectar();
                                string sql = @"DELETE FROM biblioteca.funcionarios WHERE func_CPF = @CODIGO";
                                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                                cmd.Parameters.AddWithValue("CODIGO", dgvFuncionario.CurrentRow.Cells[0].Value);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Cliente deletado do banco de dados com sucesso!");
                                txtFuncCPF.Clear();
                                txtFuncCPF.Focus();
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

        private void txtFuncCPF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvFuncionario.Show();
                Conexao.Conectar();
                string sql = "select * from biblioteca.funcionarios WHERE func_CPF LIKE '" + txtFuncCPF.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                // DataTable - Cópia da tabela para memória
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvFuncionario.DataSource = dt;
                if (txtFuncCPF.Text.Trim().Length == 0)
                {
                    dt.Reset();
                    dgvFuncionario.Hide();
                    btnAlterarFunc.Hide();
                    btn_deletarFunc.Hide();
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

        private void dgvFuncionario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAlterarFunc.Show();
            btn_deletarFunc.Show();
        }
    }
}