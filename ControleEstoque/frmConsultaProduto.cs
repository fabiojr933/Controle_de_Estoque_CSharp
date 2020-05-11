using BBL;
using DAL;
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
    public partial class frmConsultaProduto : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0;
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DALConexao con = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto produto = new BLLProduto(con);
            GridProduto.DataSource = produto.Localizar(txtPesquisa.Text);
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btnPesquisar_Click(sender, e);
            GridProduto.Columns[0].HeaderText = "ID";
            GridProduto.Columns[0].Width = 40;
            GridProduto.Columns[1].HeaderText = "PRODUTO";
            GridProduto.Columns[1].Width = 150;
            GridProduto.Columns[2].Visible = false;
            GridProduto.Columns[3].Visible = false;
            GridProduto.Columns[4].Visible = false;
            GridProduto.Columns[5].HeaderText = "PREÇO";
            GridProduto.Columns[5].Width = 85;
            GridProduto.Columns[6].HeaderText = "ESTOQUE";
            GridProduto.Columns[6].Width = 70;
            GridProduto.Columns[7].Visible = false;
            GridProduto.Columns[8].Visible = false;
            GridProduto.Columns[9].Visible = false;
        }

        private void GridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridProduto.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
