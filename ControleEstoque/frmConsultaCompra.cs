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

namespace View
{
    public partial class frmConsultaCompra : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0; 
        public frmConsultaCompra()
        {
            InitializeComponent();
        }
        public void ExecutaConsulta(int op)
        {
            // op == 1 consultar todas as compras
            // op == 2 consultar por nome
            // op == 3 consultar data
            // op == 4 consultar por parcela aberta
        }
        public void AtaulizaTabelaCompra()
        {
            GridCompra2.Columns[0].HeaderText = "Cod Compra";
            GridCompra2.Columns[0].Width = 50;
            GridCompra2.Columns[1].HeaderText = "Fornecedor";
            GridCompra2.Columns[1].Width = 160;
            GridCompra2.Columns[2].HeaderText = "Data Compra";
            GridCompra2.Columns[2].Width = 90;
            GridCompra2.Columns[3].HeaderText = "Nota Fiscal";
            GridCompra2.Columns[3].Width = 70;
            GridCompra2.Columns[4].HeaderText = "Total";
            GridCompra2.Columns[4].Width = 90;
            GridCompra2.Columns[5].HeaderText = "Status";
            GridCompra2.Columns[5].Width = 50;
            GridCompra2.Columns[6].Visible = false;
            GridCompra2.Columns[7].Visible = false;
        }
        public void AtaulizaTabelaCompraGeral()
        {
            GridCompra2.Columns[0].HeaderText = "Cod Compra";
            GridCompra2.Columns[0].Width = 50;         
            GridCompra2.Columns[1].HeaderText = "Data Compra";
            GridCompra2.Columns[1].Width = 130;
            GridCompra2.Columns[2].HeaderText = "Nota Fiscal";
            GridCompra2.Columns[2].Width = 90;
            GridCompra2.Columns[3].Visible = false;
            GridCompra2.Columns[4].HeaderText = "Total";
            GridCompra2.Columns[4].Width = 90;
            GridCompra2.Columns[5].HeaderText = "Status";
            GridCompra2.Columns[5].Width = 50;
            GridCompra2.Columns[8].Visible = false;
            GridCompra2.Columns[6].Visible = false;
            GridCompra2.Columns[7].Visible = false;
        }

        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {
            panelFornecedor.Visible = false;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor fornecedor = new frmConsultaFornecedor();
            fornecedor.ShowDialog();
            if(fornecedor.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor dao = new BLLFornecedor(conexao);
                ModeloFornecedor modelo = dao.carregaModeloCategoria(fornecedor.codigo);
                txtCodigoFornecedor.Text = modelo.For_cod.ToString();
                lblNomeFornecedor.Text = modelo.For_nome;

                //carregar
                BLLCompra compra = new BLLCompra(conexao);
                GridCompra2.DataSource = compra.LocalizarPorFornecedor(modelo.For_cod);
                AtaulizaTabelaCompra();
                fornecedor.Dispose();
            }
        }

        private void radioGeral_CheckedChanged(object sender, EventArgs e)
        {
            panelFornecedor.Visible = false;
            panelData.Visible = false;

            //limpar
            GridCompra2.DataSource = null;
            GridItens.DataSource = null;
            GridParcela2.DataSource = null;

            if (radioGeral.Checked == true)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra compra = new BLLCompra(conexao);
                GridCompra2.DataSource = compra.LocalizarPorNome("");
                this.AtaulizaTabelaCompraGeral();
            }
            if (radioDataCompra.Checked == true)
            {
                panelData.Visible = true;               
            }
            if (radioNome.Checked == true)
            {
                panelFornecedor.Visible = true;
            }
            if (radioParcelasAbertas.Checked == true)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra compra = new BLLCompra(conexao);
                GridCompra2.DataSource = compra.LocalizarPorParcela();
                this.AtaulizaTabelaCompraGeral();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime da1 = dateIncial.Value;
            DateTime da2 = dateFinal.Value;
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra compra = new BLLCompra(conexao);
            GridCompra2.DataSource = compra.LocalizarPorData(da1, da2);
            this.AtaulizaTabelaCompraGeral();
        }

        private void GridCompra2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                //itens da compra
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLItensCompra compra = new BLLItensCompra(conexao);
                GridItens.DataSource = compra.Localizar(Convert.ToInt32(GridCompra2.Rows[e.RowIndex].Cells[0].Value));

                //parcela da compra               
                BLLParcelasCompra parcela = new BLLParcelasCompra(conexao);
                GridParcela2.DataSource = parcela.Localizar(Convert.ToInt32(GridCompra2.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        private void GridCompra2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridCompra2.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
