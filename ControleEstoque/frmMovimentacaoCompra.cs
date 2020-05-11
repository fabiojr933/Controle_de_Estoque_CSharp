using BBL;
using BLL;
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
    public partial class frmMovimentacaoCompra : MetroFramework.Forms.MetroForm
    {
        private string operacao;
        public double totalCompra = 0;
        public frmMovimentacaoCompra()
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
            txtCodigo.Clear();
            txtCodProduto.Clear();
            textBox1.Clear();
            txtNotaFiscal.Clear();
            txtQuantidade.Clear();
            txtTotal.Clear();
            txtValor.Clear();
            GridItens.Rows.Clear();
            lblProduto.Text = "Inforne o codigo do PRODUTO";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoes(2);
            this.totalCompra = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.alterarBotoes(2);
            this.operacao = "alterar";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alterarBotoes(1);
            this.limparTela();
            this.totalCompra = 0;
        }

        private void frmMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            this.alterarBotoes(1);

            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento pagamento = new BLLTipoPagamento(conexao);
            cbPagamento.DataSource = pagamento.Localizar("");
            cbPagamento.DisplayMember = "tpa_nome";
            cbPagamento.ValueMember = "tpa_cod";

            

        }

        private void btnLocalizaFor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor consultaFornecedor = new frmConsultaFornecedor();
            consultaFornecedor.ShowDialog();
            if (consultaFornecedor.codigo != 0)
            {
               
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor fornecedor = new BLLFornecedor(conexao);
                ModeloFornecedor modelo = fornecedor.carregaModeloCategoria(consultaFornecedor.codigo);
                textBox2.Text = Convert.ToString(modelo.For_cod);               
                lblFornecedor.Text = modelo.For_nome;
                lblFornecedor.ForeColor = System.Drawing.Color.FromArgb(78, 109, 156);              
            }
        }

        private void btnLocalizarProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto consultaProduto= new frmConsultaProduto();
            consultaProduto.ShowDialog();
            if(consultaProduto.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto produto = new BLLProduto(conexao);
                ModeloProduto modelo = produto.carregarModeloProdutos(consultaProduto.codigo);
                txtCodProduto.Text = Convert.ToString(consultaProduto.codigo);
                lblProduto.Text = modelo.Pro_nome;
                lblProduto.ForeColor = System.Drawing.Color.FromArgb(78, 109, 156);
                txtQuantidade.Text = "1";
                txtValor.Text = Convert.ToString(modelo.Pro_valorvenda);
            }
        }

        private void txtFornecedor_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor fornecedor = new BLLFornecedor(conexao);
                ModeloFornecedor modelo = fornecedor.carregaModeloCategoria(Convert.ToInt32(textBox1.Text));
                lblFornecedor.Text = modelo.For_nome;
                lblFornecedor.ForeColor = System.Drawing.Color.FromArgb(78, 109, 156);               
            }
            catch (Exception ex)
            {
            //   textBox1.Clear();
                MetroFramework.MetroMessageBox.Show(this,"Ops ocorreu algum erro " + ex.Message,"atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto produto = new BLLProduto(conexao);
                ModeloProduto modelo = produto.carregarModeloProdutos(Convert.ToInt32(txtCodProduto.Text));
                lblProduto.Text = modelo.Pro_nome;
                lblProduto.ForeColor = System.Drawing.Color.FromArgb(78, 109, 156);
                txtQuantidade.Text = "1";
                txtValor.Text = Convert.ToString(modelo.Pro_valorvenda);
            }
            catch (Exception ex)
            {
              //  textBox1.Clear();
                MetroFramework.MetroMessageBox.Show(this, "Ops ocorreu algum erro " + ex.Message, "atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtInserir_Click(object sender, EventArgs e)
        {
            if((txtCodProduto.Text != "") &&(txtQuantidade.Text != "") && (txtValor.Text != ""))
            {
                Double totalLocal = Convert.ToDouble(txtQuantidade.Text) * Convert.ToDouble(txtValor.Text);
                this.totalCompra = this.totalCompra + totalLocal;
                String[] i = new string[] { txtCodProduto.Text, lblProduto.Text, txtQuantidade.Text, txtValor.Text, totalLocal.ToString() };
                this.GridItens.Rows.Add(i);

                txtCodProduto.Clear();
                lblProduto.Text = "Inforne o codigo do PRODUTO";
                txtQuantidade.Clear();
                txtValor.Clear();
                textBox1.Clear();
                lblFornecedor.Text = "Clique em Localizar para Vincular um fornecedor";

                txtTotal.Text = this.totalCompra.ToString();
            }
        }

        private void GridItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtCodProduto.Text = GridItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblProduto.Text = GridItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantidade.Text = GridItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = GridItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(GridItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalCompra = this.totalCompra - valor;
                GridItens.Rows.RemoveAt(e.RowIndex);
                txtTotal.Text = this.totalCompra.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GridParcelas.Rows.Clear();
            int parcelas = Convert.ToInt32(cbParcelas.Text);
            Double totalLocal = Convert.ToInt32(txtTotal.Text);
            Double valor = totalLocal / parcelas;
            DateTime dt = new DateTime();
            dt = dataPagamento.Value;
            lblTotalCompra.Text = this.totalCompra.ToString();

            for (int i = 1; i <= parcelas; i++)
            {
                string[] k = new string[] { i.ToString(), valor.ToString(), dt.ToString() };
                this.GridParcelas.Rows.Add(k);

                if (dt.Month != 12)
                {
                    dt = new DateTime(dt.Year, dt.Month +1, dt.Day);
                }
                else
                {
                    dt = new DateTime(dt.Year + 1, 1, dt.Day);
                }
            }
            panelParcelas.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelParcelas.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCompra modelo = new ModeloCompra();
                modelo.Com_data = dateCompra.Value;
                modelo.Com_nfiscal = Convert.ToInt32(txtNotaFiscal.Text);
                modelo.Com_nparcelas = Convert.ToInt32(cbParcelas.Text);
                modelo.Com_status = "EFE";
                modelo.For_cod = Convert.ToInt32(textBox2.Text);
                modelo.Tpa_cod = Convert.ToInt32(cbPagamento.SelectedValue);
                modelo.Com_total = Convert.ToDouble(txtTotal.Text);

                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra compra = new BLLCompra(conexao);

                ModeloItensCompra itensCompra = new ModeloItensCompra();
                BLLItensCompra dao = new BLLItensCompra(conexao);

                ModeloParcelasCompra parcelasCompra = new ModeloParcelasCompra();
                BLLParcelasCompra daoParcelas = new BLLParcelasCompra(conexao);
                if (operacao == "inserir")
                {
                    //cadastrar uma compra
                    compra.Incluir(modelo);
                    // cadastrar os itens da compra
                    for(int i = 0; i < GridItens.RowCount; i++)
                    {
                        itensCompra.Itc_cod = i + 1;
                        itensCompra.Com_cod = modelo.Com_cod;
                        itensCompra.Pro_cod = Convert.ToInt32(GridItens.Rows[i].Cells[0].Value);
                        itensCompra.Itc_qtde = Convert.ToInt32(GridItens.Rows[i].Cells[2].Value);
                        itensCompra.Itc_valor = Convert.ToInt32(GridItens.Rows[i].Cells[3].Value);

                        dao.Inserir(itensCompra);
                    }
                    //cadastrar as parcelas
                    for(int i =0; i < GridParcelas.RowCount; i++)
                    {
                        parcelasCompra.Com_cod = modelo.Com_cod;
                        parcelasCompra.Pco_cod = Convert.ToInt32(GridParcelas.Rows[i].Cells[0].Value);
                        parcelasCompra.Pco_valor = Convert.ToDouble(GridParcelas.Rows[i].Cells[1].Value);
                        parcelasCompra.Pco_datavecto = Convert.ToDateTime(GridParcelas.Rows[i].Cells[2].Value);

                        daoParcelas.Incluir(parcelasCompra);
                    }                 

                    MetroFramework.MetroMessageBox.Show(this, "Compra efetuada com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    compra.Alterar(modelo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }           
           
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCompra compra = new frmConsultaCompra();
            compra.ShowDialog();
            if(compra.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra dao = new BLLCompra(conexao);
                ModeloCompra modelo = dao.CarregaModeloCompra(compra.codigo);

                txtCodigo.Text = modelo.Com_cod.ToString();
                txtNotaFiscal.Text = modelo.Com_nfiscal.ToString();
                dateCompra.Value = modelo.Com_data;
                textBox2.Text = modelo.For_cod.ToString();

                BLLFornecedor fornecedor = new BLLFornecedor(conexao);
                ModeloFornecedor modelo2 = fornecedor.carregaModeloCategoria(Convert.ToInt32(modelo.For_cod));
                lblFornecedor.Text = modelo2.For_nome;
                lblFornecedor.ForeColor = System.Drawing.Color.FromArgb(78, 109, 156);


                txtTotal.Text = modelo.Com_total.ToString();
                this.totalCompra = modelo.Com_total;
                cbPagamento.SelectedValue = modelo.Tpa_cod;
                alterarBotoes(3);
            }
            else
            {
                this.limparTela();
                this.alterarBotoes(1);
            }
           // this.Dispose();
        }
    }
}
