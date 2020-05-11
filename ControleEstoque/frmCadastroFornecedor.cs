using Modelo;
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
using BLL;
using Ferramentas;


namespace View
{
    public partial class frmCadastroFornecedor : MetroFramework.Forms.MetroForm
    {
        public string operacao;
        public frmCadastroFornecedor()
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
            txtFornecedor.Clear();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloFornecedor fornecedor = new ModeloFornecedor();
                fornecedor.For_nome = txtFornecedor.Text;
                fornecedor.For_rsocial = txtRsocial.Text;
                fornecedor.For_ie = txtRGIE.Text;
                fornecedor.For_cnpj = txtCPFCNPJ.Text;
                fornecedor.For_cep = txtCep.Text;
                fornecedor.For_endereco = txtRua.Text;
                fornecedor.For_bairro = txtBairro.Text;
                fornecedor.For_fone = txtTelefone.Text;
                fornecedor.For_cel = txtCelular.Text;
                fornecedor.For_email = txtMail.Text;
                fornecedor.For_endnumero = txtNumero.Text;
                fornecedor.For_cidade = txtCidade.Text;
                fornecedor.For_estado = txtEstado.Text;
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor dao = new BLLFornecedor(conexao);
                if(operacao == "inserir")
                {
                    dao.Incluir(fornecedor);
                    MetroFramework.MetroMessageBox.Show(this,"Cadastrado com sucesso","Cadastrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.limparTela();
                    this.alterarBotoes(1);
                }
                else
                {
                    fornecedor.For_cod = Convert.ToInt32(txtCodigo.Text);
                    dao.Alterar(fornecedor);
                    MetroFramework.MetroMessageBox.Show(this, "Alterado com sucesso", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limparTela();
                    this.alterarBotoes(1);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "erro " + ex.Message, "erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            txtRsocial.Visible = true;
            blRsocial.Visible = true;
            this.alterarBotoes(1);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alterarBotoes(1);
            this.limparTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MetroFramework.MetroMessageBox.Show(this,"Deseja relamente excluir","ATENÇÃO",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            try
            {
                if (resultado.ToString() == "Yes")
                {
                    ModeloFornecedor modelo = new ModeloFornecedor();
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFornecedor fornecedor = new BLLFornecedor(conexao);
                    fornecedor.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.alterarBotoes(1);
                    this.limparTela();
                    MetroFramework.MetroMessageBox.Show(this, "Excluido com sucesso", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "erro " + ex.Message, "erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor consultaFornecedor = new frmConsultaFornecedor();
            consultaFornecedor.ShowDialog();

            try
            {
                if (consultaFornecedor.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFornecedor fornecedor = new BLLFornecedor(conexao);
                    ModeloFornecedor modelo = fornecedor.carregaModeloCategoria(consultaFornecedor.codigo);
                    txtCodigo.Text = Convert.ToString(modelo.For_cod);
                    txtFornecedor.Text = modelo.For_nome;
                    txtRsocial.Text = modelo.For_rsocial;

                    txtRGIE.Text = modelo.For_ie;
                    txtCPFCNPJ.Text = modelo.For_cnpj;
                    txtCep.Text = modelo.For_cep;
                    txtRua.Text = modelo.For_endereco;
                    txtBairro.Text = modelo.For_bairro;
                    txtTelefone.Text = modelo.For_fone;
                    txtCelular.Text = modelo.For_cel;
                    txtMail.Text = modelo.For_email;
                    txtNumero.Text = modelo.For_endnumero;
                    txtCidade.Text = modelo.For_cidade;
                    txtEstado.Text = modelo.For_estado;

                    this.alterarBotoes(3);
                }
                else
                {
                    limparTela();
                    alterarBotoes(1);
                }
                consultaFornecedor.Dispose();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "erro " + ex.Message, "erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCPFCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite numeros
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtRGIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite numeros
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite numeros
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite numeros
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite numeros
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }
    }
}
