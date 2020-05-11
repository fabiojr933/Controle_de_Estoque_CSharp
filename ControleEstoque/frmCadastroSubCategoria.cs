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
    public partial class frmCadastroSubCategoria : MetroFramework.Forms.MetroForm
    {
        public string operacao;
        public frmCadastroSubCategoria()
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
            txtSubCategoria.Clear();
            txtCodigo.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria consultaSubCategoria = new frmConsultaSubCategoria();
            consultaSubCategoria.ShowDialog();

            try
            {
                if (consultaSubCategoria.Codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria categoria = new BLLSubCategoria(conexao);
                    ModeloSubCategoria modelo = categoria.CarregarModeloSubCategoria(consultaSubCategoria.Codigo);
                    txtCodigo.Text = modelo.Scat_cod.ToString();
                    txtSubCategoria.Text = modelo.Scat_nome;
                    cboCategoria.SelectedValue = modelo.Cat_cod;
                    alterarBotoes(3);
                }
                else
                {
                    this.limparTela();
                    this.alterarBotoes(1);
                }
                consultaSubCategoria.Dispose();
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
                DialogResult resultado = MetroFramework.MetroMessageBox.Show(this,"Tem certeza que deseja realmente excluir", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado.ToString() == "Yes")
                {
                    DALConexao con = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria categoria = new BLLSubCategoria(con);
                    categoria.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.limparTela();
                    this.alterarBotoes(1);
                    MetroFramework.MetroMessageBox.Show(this,"Cadastrado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Ops ocorreu algum erro" + ex.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.alterarBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.Scat_nome = txtSubCategoria.Text;
                modelo.Cat_cod = Convert.ToInt32(cboCategoria.SelectedValue);
                DALConexao dao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria categoria = new BLLSubCategoria(dao);
                if (this.operacao == "inserir")
                {
                    //cadastrar
                    categoria.Incluir(modelo);
                    MetroFramework.MetroMessageBox.Show(this,"Cadastrado com sucesso! ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limparTela();
                    this.alterarBotoes(1);
                }
                else
                {
                    //alterar
                    modelo.Scat_cod = Convert.ToInt32(txtCodigo.Text);
                    categoria.Alterar(modelo);
                    MetroFramework.MetroMessageBox.Show(this,"Editado com sucesso! ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limparTela();
                    this.alterarBotoes(1);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Ops Ocorreu algum erro! " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alterarBotoes(1);
            this.limparTela();
        }

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.alterarBotoes(1);
            DALConexao dao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria categoria = new BLLCategoria(dao);
            cboCategoria.DataSource = categoria.Localizar("");
            cboCategoria.DisplayMember = "cat_nome";
            cboCategoria.ValueMember = "cat_cod";
        }
    }
}
