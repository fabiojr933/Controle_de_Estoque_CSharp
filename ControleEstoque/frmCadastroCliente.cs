using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Modelo;
using BLL;
using System.Data.SqlClient;
using Ferramentas;

namespace View
{
    public partial class frmCadastroCliente : MetroFramework.Forms.MetroForm
    {
     

        public string operacao;
        public frmCadastroCliente()
        {
            InitializeComponent();
        }
        public void alterarBotoes(int op)
        {
            panel1.Enabled = false;
            btnInserir.Enabled = false;
            btnEditar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false; ;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                panel1.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
        public void limparTela()
        {
            txtCliente.Clear();
            txtCodigo.Clear();
            txtRsocial.Clear();
            txtBairro.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtCPFCNPJ.Clear();
            txtMail.Clear();
            txtEstado.Clear();
            txtCelular.Clear();
            txtRua.Clear();
            txtRGIE.Clear();
            txtCep.Clear();
            txtNumero.Clear();
            txtTelefone.Clear();

            radioFisica.Checked = true;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoes(2);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterarBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MetroFramework.MetroMessageBox.Show(this,"Deseja excluir realmente ?","ATENÇÃO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            try
            {
                if (mensagem.ToString() == "Yes")
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente cliente = new BLLCliente(conexao);
                    cliente.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.limparTela();
                    this.alterarBotoes(1);
                    MetroFramework.MetroMessageBox.Show(this, "Daletado com sucesso ", "ATENÇAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Imppossivel deletar esse registro " + ex.Message,"ATENÇAO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.alterarBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCliente cliente = new ModeloCliente();
                cliente.Cli_nome = txtCliente.Text;
                cliente.Cli_rsocial = txtRsocial.Text;
                cliente.Cli_cpfcnpj = txtCPFCNPJ.Text;
                cliente.Cli_rgie = txtRGIE.Text;
                cliente.Cli_cep = txtCep.Text;
                cliente.Cli_estado = txtEstado.Text;
                cliente.Cli_cidade = txtCidade.Text;
                cliente.Cli_endereco = txtRua.Text;
                cliente.Cli_endnumero = txtNumero.Text;
                cliente.Cli_bairro = txtBairro.Text;
                cliente.Cli_email = txtMail.Text;
                cliente.Cli_cel = txtCelular.Text;
                cliente.Cli_fone = txtTelefone.Text;

                if(radioFisica.Checked == true)
                {
                    cliente.Cli_tipo = "F";
                }
                else
                {
                    cliente.Cli_tipo = "J";
                }

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente dao = new BLLCliente(conexao);
                if(operacao == "inserir")
                {
                    dao.Incluir(cliente);
                    MetroFramework.MetroMessageBox.Show(this,"Cliente salvo com sucesso","CADASTRADO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.limparTela();
                    this.alterarBotoes(1);
                }
                else
                {
                    cliente.Cli_cod = Convert.ToInt32(txtCodigo.Text);
                    dao.Alterar(cliente);
                    MetroFramework.MetroMessageBox.Show(this, "Cliente Editado com sucesso", "EDITADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limparTela();
                    this.alterarBotoes(1);
                }
            }
            catch (Exception EX)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ops! Ocorreu algum erro" + EX.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alterarBotoes(1);
            this.limparTela();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.alterarBotoes(1);
        }

        private void radioFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFisica.Checked == true)
            {
                blRsocial.Visible = false;
                txtRsocial.Visible = false;
                lbCFPCNPJ.Text = "CPF";
                lbRGIE.Text = "RG";
            }
            else
            {
                blRsocial.Visible = true;
                txtRsocial.Visible = true;
                lbCFPCNPJ.Text = "CNPJ";
                lbRGIE.Text = "IE";
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (BuscaEndereco.verificaCEP(txtCep.Text) == true)
            {
                txtBairro.Text = BuscaEndereco.bairro;
                txtEstado.Text = BuscaEndereco.estado;
                txtCidade.Text = BuscaEndereco.cidade;
                txtRua.Text = BuscaEndereco.endereco;
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCliente consultaCliente = new frmConsultaCliente();
            consultaCliente.ShowDialog();

            try
            {
                if (consultaCliente.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente cliente = new BLLCliente(conexao);
                    ModeloCliente modelo = cliente.carregaModeloClienteCod(consultaCliente.codigo);
                   
                    txtCodigo.Text = Convert.ToString(modelo.Cli_cod);
                    txtCliente.Text = modelo.Cli_nome;
                    txtRsocial.Text = modelo.Cli_rsocial;
                    if (modelo.Cli_tipo == "F")
                    {
                        radioFisica.Checked = true;
                    }
                    else
                    {
                        radioJuridica.Checked = true;
                    }
                    txtCPFCNPJ.Text = modelo.Cli_cpfcnpj;
                    txtRGIE.Text = modelo.Cli_rgie;
                    txtEstado.Text = modelo.Cli_estado;
                    txtCidade.Text = modelo.Cli_cidade;
                    txtCep.Text = modelo.Cli_cep;
                    txtRua.Text = modelo.Cli_endereco;
                    txtBairro.Text = modelo.Cli_bairro;
                    txtNumero.Text = modelo.Cli_endnumero;
                    txtMail.Text = modelo.Cli_email;
                    txtCelular.Text = modelo.Cli_cel;
                    txtTelefone.Text = modelo.Cli_fone;

                    this.alterarBotoes(3);
                }
                else
                {
                    this.limparTela();
                    this.alterarBotoes(1);
                }
                consultaCliente.Dispose();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Ops!! ocorreu algum erro " + ex.Message,"Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtCPFCNPJ_Leave(object sender, EventArgs e)
        {            
            //lblValidador.Visible = false;
            //if (radioFisica.Checked == true)
            //{
            //    if(Validacao.IsCpf(txtCPFCNPJ.Text) == false)
            //    {
            //        lblValidador.Visible = true;                   
            //    }
            //}
            //else
            //{
            //    if (Validacao.IsCnpj(txtCPFCNPJ.Text) == false)
            //    {
            //        lblValidador.Visible = true;
            //    }
            //}
        }

    }
}
