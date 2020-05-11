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
    public partial class frmCadastroUniMedida : MetroFramework.Forms.MetroForm
    {
        public string operacao;
        public frmCadastroUniMedida()
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
            txtUniMedida.Clear();
            txtCodigo.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUniMedida uniMedida = new frmConsultaUniMedida();
            uniMedida.ShowDialog();
            try
            {
                if (uniMedida.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidMedida model = new BLLUnidMedida(conexao);
                    ModeloUndMedida modelo = model.carregarUnidades(uniMedida.codigo);
                    txtCodigo.Text = Convert.ToString(modelo.Umed_cod);
                    txtUniMedida.Text = modelo.Umed_nome;
                    this.alterarBotoes(3);
                }
                else
                {
                    limparTela();
                    this.alterarBotoes(1);
                }
                uniMedida.Dispose();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Impossivel encontrar o registro. \n O resistro esta sendo utilizado em outro local " + ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterarBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MetroFramework.MetroMessageBox.Show(this,"Realmente deseja excluir? ", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado.ToString() == "Yes")
                {
                    ModeloUndMedida undMedida = new ModeloUndMedida();
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidMedida medida = new BLLUnidMedida(conexao);
                    medida.Excluir(Convert.ToInt32(txtCodigo.Text));
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
                ModeloUndMedida undMedida = new ModeloUndMedida();
                undMedida.Umed_nome = txtUniMedida.Text;
                DALConexao dao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidMedida medida = new BLLUnidMedida(dao);
                if (this.operacao == "inserir")
                {
                    medida.Inserir(undMedida);
                    MetroFramework.MetroMessageBox.Show(this,"Cadastrado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limparTela();
                    this.alterarBotoes(1);
                }
                else
                {
                    undMedida.Umed_cod = Convert.ToInt32(txtCodigo.Text);
                    medida.Alterar(undMedida);
                    MetroFramework.MetroMessageBox.Show(this,"Alterado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limparTela();
                    this.alterarBotoes(1);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"ops Ocorreu algum erro " + ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alterarBotoes(1);
            this.limparTela();
        }
    }
}
