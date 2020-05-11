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
    public partial class frmConsultaCategoria : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0;
        public frmConsultaCategoria()
        {
            InitializeComponent();
        }

        private void frmConsultaCategoria_Load(object sender, EventArgs e)
        {
         //   panel1.BackColor = Color.FromArgb(78, 109, 156);

            btnPesquisar_Click(sender, e);
            GridCategoria.Columns[0].HeaderText = "Codigo";
            GridCategoria.Columns[0].Width = 70;
            GridCategoria.Columns[1].HeaderText = "Categoria";
            GridCategoria.Columns[1].Width = 280;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria categoria = new BLLCategoria(conexao);
            GridCategoria.DataSource = categoria.Localizar(txtPesquisa.Text.ToUpper());
        }

        private void GridCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridCategoria.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void GridCategoria_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridCategoria.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void GridCategoria_CellDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridCategoria.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
