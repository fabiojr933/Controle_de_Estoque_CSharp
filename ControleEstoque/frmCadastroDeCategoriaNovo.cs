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
    public partial class frmCadastroDeCategoriaNovo : MetroFramework.Forms.MetroForm
    {
        public string operacao;
        public frmCadastroDeCategoriaNovo()
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
            txtCategoria.Clear();
            txtCodigo.Clear();
        }

        private void frmCadastroDeCategoriaNovo_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(78, 109, 156);
            //panel2.BackColor = Color.FromArgb(78, 109, 156);
            this.alterarBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria consultaCategoria = new frmConsultaCategoria();
            consultaCategoria.ShowDialog();

            try
            {
                if (consultaCategoria.codigo != 0)
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCategoria categoria = new BLLCategoria(conexao);
                    ModeloCategoria modelo = categoria.carregaModeloCategoria(consultaCategoria.codigo);
                    txtCodigo.Text = modelo.Cat_cod.ToString();
                    txtCategoria.Text = modelo.Cat_nome;
                    this.alterarBotoes(3);
                }
                else
                {
                    this.limparTela();
                    this.alterarBotoes(1);
                }
                consultaCategoria.Dispose();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Impossivel encontrar o registro. \n O resistro esta sendo utilizado em outro local " + ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DialogResult resultado = MetroFramework.MetroMessageBox.Show(this,"Deseja excluir o registro? ", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado.ToString() == "Yes")
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCategoria categoria = new BLLCategoria(conexao);
                    categoria.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.limparTela();
                    this.alterarBotoes(1);
                    MetroFramework.MetroMessageBox.Show(this,"Excluido com sucesso! ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Impossivel excluir o registro. \n O resistro esta sendo utilizado em outro local " + ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.alterarBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCategoria modelo = new ModeloCategoria();
                modelo.Cat_nome = txtCategoria.Text;
                DALConexao dao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria categoria = new BLLCategoria(dao);
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
                    modelo.Cat_cod = Convert.ToInt32(txtCodigo.Text);
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
            //limpar a tela
            this.limparTela();
            this.alterarBotoes(1);
        }
    }
}
