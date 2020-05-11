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
    public partial class frmConsultaUniMedida : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0;
        public frmConsultaUniMedida()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUnidMedida unidMedida = new BLLUnidMedida(conexao);
            GridUnidade.DataSource = unidMedida.Localizar(txtPesquisa.Text.ToUpper());
        }

        private void frmConsultaUniMedida_Load(object sender, EventArgs e)
        {
            btnPesquisar_Click(sender, e);
            GridUnidade.Columns[0].HeaderText = "ID";
            GridUnidade.Columns[0].Width = 80;
            GridUnidade.Columns[1].HeaderText = "Und Medida";
            GridUnidade.Columns[1].Width = 220;
        }

        private void GridUnidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridUnidade.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
