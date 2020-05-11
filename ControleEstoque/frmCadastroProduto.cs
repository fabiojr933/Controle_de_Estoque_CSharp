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
    public partial class frmCadastroProduto : MetroFramework.Forms.MetroForm
    {
        public void LimpaCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtNome.Clear();
            txtValorPago.Clear();
            txtValorVenda.Clear();
            txtEstoque.Clear();
            this.foto = "";
            pictureFoto.Image = null;

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
        public string foto = "";
        public string operacao;

        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtValorPago.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }






            ////só permite numeros
            //if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            //{
            //    e.Handled = true;
            //}
        }

        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite numeros
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void metroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //só permite numeros
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == ',') && !(e.KeyChar == Convert.ToChar(8)))
            {
                e.Handled = true;
            }
        }

        private void metroTextBox2_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(".") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += ",00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch (Exception)
            {
                txtValorVenda.Text = "0,00";
            }
        }

        private void metroTextBox3_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(",") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += ",00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch (Exception)
            {
                txtValorVenda.Text = "0,00";
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (cboCategoria.SelectedIndex <= 0)
                {
                    return;
                }
                //COMBO DA SUB CATEGORIA
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria sub = new BLLSubCategoria(conexao);
                cboSubCategoria.DataSource = sub.LocalizaPorCategoria(Convert.ToInt32(cboCategoria.SelectedValue));


                cboSubCategoria.DisplayMember = "scat_nome";
                cboSubCategoria.ValueMember = "scat_cod";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ft = new OpenFileDialog();
            ft.ShowDialog();
            if (!String.IsNullOrEmpty(ft.FileName))
            {
                this.foto = ft.FileName;
                pictureFoto.Load(this.foto);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            this.foto = @"C:\image.jpg";
            //Image image = Image.FromFile(@"C:\image.jpg");
            //pictureFoto.Image = image;
            


        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            alterarBotoes(2);
            this.operacao = "inserir";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaProduto consultaProduto = new frmConsultaProduto();
            consultaProduto.ShowDialog();

            try
            {
                if (consultaProduto.codigo != 0)
                {
                    DALConexao con = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto daoProduto = new BLLProduto(con);
                    ModeloProduto modelo = daoProduto.carregarModeloProdutos(consultaProduto.codigo);
                    txtCodigo.Text = modelo.Pro_cod.ToString();
                    txtNome.Text = modelo.Pro_nome;
                    txtDescricao.Text = modelo.Pro_descricao;
                    txtEstoque.Text = modelo.Pro_qtde.ToString();
                    txtValorPago.Text = Convert.ToString(modelo.Pro_valorpago);
                    txtValorVenda.Text = modelo.Pro_valorvenda.ToString();
                    cboCategoria.SelectedValue = modelo.Cat_cod;
                    cboSubCategoria.SelectedValue = modelo.Scat_cod;
                    cboUnidMedida.SelectedValue = modelo.Umed_cod;
                  
                    alterarBotoes(3);

                    //recuperar a foto
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(modelo.Pro_foto);
                    pictureFoto.Image = Image.FromStream(ms);
                    this.foto = "foto original";
                }
                else
                {
                    this.LimpaCampos();
                    this.alterarBotoes(1);
                }
                consultaProduto.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                DialogResult resultado = MetroFramework.MetroMessageBox.Show(this,"Deseja relamente excluir o produto", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado.ToString() == "Yes")
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto produto = new BLLProduto(conexao);
                    produto.Excluir(Convert.ToInt32(txtCodigo.Text));
                    MetroFramework.MetroMessageBox.Show(this,"Deletado com suesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                this.LimpaCampos();
                this.alterarBotoes(1);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Ops! ocorreu algum erro "+ ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto daoProduto = new BLLProduto(conexao);
                ModeloProduto produto = new ModeloProduto();
                produto.Pro_nome = txtNome.Text;
                produto.Pro_descricao = txtDescricao.Text;
                produto.Pro_valorpago = Convert.ToDouble(txtValorPago.Text);
                produto.Pro_valorvenda = Convert.ToDouble(txtValorVenda.Text);
                produto.Pro_qtde = Convert.ToInt32(txtEstoque.Text);
                produto.Cat_cod = Convert.ToInt32(cboCategoria.SelectedValue);
                produto.Scat_cod = Convert.ToInt32(cboSubCategoria.SelectedValue);
                produto.Umed_cod = Convert.ToInt32(cboUnidMedida.SelectedValue);
                if (this.operacao == "inserir")
                {
                    produto.CarregaImage(this.foto);
                    daoProduto.Incluir(produto);
                    MetroFramework.MetroMessageBox.Show(this,"Cadastrado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    produto.Pro_cod = Convert.ToInt32(txtCodigo.Text);
                    if (this.foto == "foto original")
                    {
                        ModeloProduto mt = daoProduto.carregarModeloProdutos(produto.Pro_cod);
                        produto.Pro_foto = mt.Pro_foto;
                        daoProduto.Alterar(produto);
                        MetroFramework.MetroMessageBox.Show(this,"Alterado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        produto.CarregaImage(this.foto);
                        daoProduto.Alterar(produto);
                        MetroFramework.MetroMessageBox.Show(this,"Alterado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                this.LimpaCampos();
                this.alterarBotoes(1);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,"Erro " + ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alterarBotoes(1);
            this.LimpaCampos();
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            alterarBotoes(1);

            ////COMBO DA CATEGORIA
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria daoCategoria = new BLLCategoria(conexao);
            cboCategoria.DataSource = daoCategoria.Localizar("");
            cboCategoria.DisplayMember = "cat_nome";
            cboCategoria.ValueMember = "cat_cod";
            //cboCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            //cboCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            try
            {
                BLLSubCategoria sub = new BLLSubCategoria(conexao);
                cboSubCategoria.DataSource = sub.LocalizaPorCategoria(1);
                //cbSubCategoria.DataSource = sub.LocalizaPorCategoria((int)cbCategoria.SelectedValue);
                cboSubCategoria.DisplayMember = "scat_nome";
                cboSubCategoria.ValueMember = "scat_cod";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            //COMBO UNIDADE DE MEDIDA
            BLLUnidMedida daoUniMedida = new BLLUnidMedida(conexao);
            cboUnidMedida.DataSource = daoUniMedida.Localizar("");
            cboUnidMedida.DisplayMember = "umed_nome";
            cboUnidMedida.ValueMember = "umed_cod";
        }
    }
}
