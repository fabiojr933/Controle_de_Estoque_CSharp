using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BBL;
using BLL;
using DAL;
using Modelo;


namespace View
{
    public partial class frmConsultaFornecedor : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0;
        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor fornecedor = new BLLFornecedor(conexao);
            GridFornecedor.DataSource = fornecedor.Localizar(txtPesquisa.Text);
        }

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            btnPesquisar_Click(sender, e);
            GridFornecedor.Columns[0].HeaderText = "Id";
            GridFornecedor.Columns[0].Width = 50;
            GridFornecedor.Columns[1].HeaderText = "Nome";
            GridFornecedor.Columns[1].Width = 120;
            GridFornecedor.Columns[2].HeaderText = "CNPJ";
            GridFornecedor.Columns[2].Width = 80;
            GridFornecedor.Columns[3].HeaderText = "Telefone";
            GridFornecedor.Columns[3].Width = 80;
        }

        private void GridFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridFornecedor.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
