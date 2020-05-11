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
using BLL;
using Modelo;

namespace View
{
    public partial class frmConsultaCliente : MetroFramework.Forms.MetroForm
    {
        public int codigo = 0;
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente cliente = new BLLCliente(conexao);
            if (radioNome.Checked == true)
            {                
                GridCliente.DataSource = cliente.Localizar(txtPesquisa.Text);
            }
            else
            {                
                GridCliente.DataSource = cliente.Localizarcpf(txtPesquisa.Text);
            }
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            btnPesquisar_Click(sender, e);
            GridCliente.Columns[0].HeaderText = "Id";
            GridCliente.Columns[0].Width = 50;
            GridCliente.Columns[1].HeaderText = "Nome";
            GridCliente.Columns[1].Width = 180;
            GridCliente.Columns[2].HeaderText = "CFP CNPJ";
            GridCliente.Columns[2].Width = 90;
            GridCliente.Columns[3].Visible = false;
            GridCliente.Columns[4].Visible = false;
            GridCliente.Columns[5].Visible = false;
            GridCliente.Columns[6].Visible = false;
            GridCliente.Columns[7].Visible = false;
            GridCliente.Columns[8].Visible = false;
            GridCliente.Columns[9].HeaderText = "Telefone";
            GridCliente.Columns[9].Width = 90;
            GridCliente.Columns[10].Visible = false;
            GridCliente.Columns[11].Visible = false;
            GridCliente.Columns[12].Visible = false;
            GridCliente.Columns[13].Visible = false;
            GridCliente.Columns[14].Visible = false;
        }

        private void GridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridCliente.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
