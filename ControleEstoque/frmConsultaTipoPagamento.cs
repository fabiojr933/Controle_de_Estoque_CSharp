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
    public partial class frmConsultaTipoPagamento : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0;
        public frmConsultaTipoPagamento()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento dao = new BLLTipoPagamento(conexao);
            GridTipoPag.DataSource = dao.Localizar(txtPesquisa.Text.ToUpper());
        }

        private void frmConsultaTipoPagamento_Load(object sender, EventArgs e)
        {
            btnPesquisar_Click(sender, e);
            GridTipoPag.Columns[0].HeaderText = "CODIGO";
            GridTipoPag.Columns[0].Width = 80;
            GridTipoPag.Columns[1].HeaderText = "TIPO PAGAMENTO";
            GridTipoPag.Columns[1].Width = 260;
        }

        private void GridTipoPag_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridTipoPag.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
