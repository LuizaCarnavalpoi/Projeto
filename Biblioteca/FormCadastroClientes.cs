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

    public partial class TelaCadastroClientes : Form
    {
        public TelaCadastroClientes()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_nomeCli.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txt_nomeCli, "Preencha o campo nome!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txt_nomeCli, "");
            }
            if (mskCPF.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskCPF, "Preencha o campo CPF!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskCPF, "");
            }

            try
            {
                Conexao.Conectar();
                string sql = @"INSERT INTO biblioteca.clientes(client_CPF,client_NOME, 
                        client_CELULAR,client_EMAIL,client_DATA,client_CEP, client_CIDADE, client_ESTADO, 
                        client_RUA, client_NUM, client_COMPLEMENTO, client_BAIRRO) 
                        VALUES (@cpf, @nome, @celular, @email,@data, @cep, @cidade, @estado,
                                @rua, @num, @complemento, @bairro)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

                cmd.Parameters.AddWithValue("cpf", mskCPF.Text);
                cmd.Parameters.AddWithValue("nome", txt_nomeCli.Text);
                cmd.Parameters.AddWithValue("celular", msk_CelCli.Text);
                cmd.Parameters.AddWithValue("email", txt_emailCli.Text);
                cmd.Parameters.AddWithValue("data", mskDataNasc.Text);
                cmd.Parameters.AddWithValue("cep", mskCEPCli.Text);
                cmd.Parameters.AddWithValue("cidade", cmb_cidadeCli.Text);
                cmd.Parameters.AddWithValue("estado", cmb_estadoCli.Text);
                cmd.Parameters.AddWithValue("rua", txt_ruaCli.Text);
                cmd.Parameters.AddWithValue("num", txt_NumeroCli.Text);
                cmd.Parameters.AddWithValue("complemento", txt_complementoCli.Text);
                cmd.Parameters.AddWithValue("bairro", txt_bairroCli.Text);
                // Adicionar imagem NULL no banco de dados

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!");

                Conexao.Fechar();


                //Utils.limparCampos(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_bairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt_complemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txt_Numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_rua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void LocalizarCEP()
        {
            using (var ws = new WSCEP.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(mskCEPCli.Text);
                    cmb_cidadeCli.Text = resultado.cidade;
                    cmb_estadoCli.Text = resultado.uf;
                    txt_ruaCli.Text = resultado.end;
                    txt_bairroCli.Text = resultado.bairro;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            }
        }

        private void cmb_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_cep_TextChanged(object sender, EventArgs e)
        {

        }

        private void msk_Cel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            if (mskCEPCli.Text.Trim().Length == 9)
            {
                LocalizarCEP();
            }
        }

        private void mskCEP_TextChanged(object sender, EventArgs e)
        {
            if (mskCEPCli.Text.Trim().Length != 9)
            {
                cmb_cidadeCli.ResetText();
                cmb_estadoCli.ResetText();
                txt_bairroCli.Clear();
                txt_complementoCli.Clear();
                txt_ruaCli.Clear();
            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE biblioteca.clientes SET 
                client_NOME = @NOME,
                client_CELULAR = @CELULAR,
                client_EMAIL = @EMAIL,
                client_DATA = @DATA,
                client_CEP = @CEP,
                client_CIDADE = @CIDADE,
                client_ESTADO = @ESTADO, 
                client_RUA = @RUA,
                client_NUM = @NUM,
                client_COMPLEMENTO = @COMPLEMENTO,
                client_BAIRRO = @BAIRRO
                Where client_CPF = @CPF";

                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("CPF", mskCPF.Text);
                cmd.Parameters.AddWithValue("NOME", txt_nomeCli.Text);
                cmd.Parameters.AddWithValue("EMAIL", txt_emailCli.Text);
                cmd.Parameters.AddWithValue("CELULAR", msk_CelCli.Text);
                cmd.Parameters.AddWithValue("DATA", mskDataNasc.Text);
                cmd.Parameters.AddWithValue("RUA", txt_ruaCli.Text);
                cmd.Parameters.AddWithValue("CEP", mskCEPCli.Text);
                cmd.Parameters.AddWithValue("COMPLEMENTO", txt_complementoCli.Text);
                cmd.Parameters.AddWithValue("BAIRRO", txt_bairroCli.Text);
                cmd.Parameters.AddWithValue("CIDADE", cmb_cidadeCli.Text);
                cmd.Parameters.AddWithValue("ESTADO", cmb_estadoCli.Text);
                cmd.Parameters.AddWithValue("NUM", txt_NumeroCli.Text);

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

        private void TelaCadastroClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
