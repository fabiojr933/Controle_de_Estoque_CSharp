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
    public partial class frmConsultaSubCategoria : MetroFramework.Forms.MetroForm
    {
        public int Codigo = 0;
        public frmConsultaSubCategoria()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DALConexao con = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubCategoria categoria = new BLLSubCategoria(con);
            GridCategoria.DataSource = categoria.Localizar(txtPesquisa.Text.ToUpper());
        }

        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            btnPesquisar_Click(sender, e);
            GridCategoria.Columns[0].HeaderText = "Codigo";
            GridCategoria.Columns[0].Width = 50;
            GridCategoria.Columns[1].HeaderText = "SubCategoria";
            GridCategoria.Columns[1].Width = 140;
            //dataGridViewSubCategoria.Columns[2].HeaderText = "Cod Categoria";
            //dataGridViewSubCategoria.Columns[2].Width = 50;
            GridCategoria.Columns[2].Visible = false;
            GridCategoria.Columns[3].HeaderText = "Categoria";
            GridCategoria.Columns[3].Width = 100;
        }

        private void GridCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.Codigo = Convert.ToInt32(GridCategoria.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
