using BBL;
using DAL;
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

namespace View
{
    public partial class frmCadastroTipoPagamento : MetroFramework.Forms.MetroForm
    {
        public string operacao;
        public frmCadastroTipoPagamento()
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
            txtTipoPag.Clear();
            txtCodigo.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento tipoPagamento = new frmConsultaTipoPagamento();
            tipoPagamento.ShowDialog();

            try
            {
                if (tipoPagamento.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTipoPagamento dao = new BLLTipoPagamento(conexao);
                    ModeloTipoPagamento modelo = dao.carregarTipoPagamentos(tipoPagamento.codigo);
                    txtCodigo.Text = Convert.ToString(modelo.Tpa_cod);
                    txtTipoPag.Text = modelo.Tpa_nome;
                    this.alterarBotoes(3);
                }
                else
                {
                    this.alterarBotoes(1);
                    this.limparTela();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Impossivel encontrar o registro. \n O resistro esta sendo utilizado em outro local " + ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterrar";
            this.alterarBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MetroFramework.MetroMessageBox.Show(this,"Tem ceretza que deseja excluir?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (resultado.ToString() == "Yes")
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLTipoPagamento tipoPagamento = new BLLTipoPagamento(conexao);
                    tipoPagamento.Excluir(Convert.ToInt32(txtCodigo.Text));
                    MetroFramework.MetroMessageBox.Show(this,"Excluido com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limparTela();
                    this.alterarBotoes(1);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"ops Ocorreu algum erro " + ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloTipoPagamento tipoPagamento = new ModeloTipoPagamento();
                tipoPagamento.Tpa_nome = txtTipoPag.Text;
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento dao = new BLLTipoPagamento(conexao);

                if (operacao == "inserir")
                {
                    dao.Incluir(tipoPagamento);
                    MetroFramework.MetroMessageBox.Show(this,"Cadastrado com sucesso ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.alterarBotoes(1);
                    this.limparTela();
                }
                else
                {
                    tipoPagamento.Tpa_cod = Convert.ToInt32(txtCodigo.Text);
                    dao.Alterar(tipoPagamento);
                    MetroFramework.MetroMessageBox.Show(this,"Alterado com sucesso ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.alterarBotoes(1);
                    this.limparTela();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Erro ao realizar o cadastro " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadastroTipoPagamento_Load(object sender, EventArgs e)
        {
            this.alterarBotoes(1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alterarBotoes(1);
            this.limparTela();
        }
    }
}
