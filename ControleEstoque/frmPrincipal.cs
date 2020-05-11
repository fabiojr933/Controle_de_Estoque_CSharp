using DAL;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace ControleEstoque
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
           
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(78, 109, 156);
            label2.Text = DateTime.Now.ToString();

            try
            {
                StreamReader arquivo = new StreamReader("configuracaoBanco.txt");
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this,"Ops! ocorreu algum erro ao se conectar com banco de dados \n " +
                     "verifique sua configuração do banco de dados do sistema \n " +
                     "ACESSE FERRAMENTAS E INFORME OS PARAMENTROS DA CONEXÃO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception )
            {
                MetroFramework.MetroMessageBox.Show(this, "Ops! ocorreu algum erro ao se conectar com banco de dados \n " +
                     "verifique sua configuração do banco de dados do sistema \n " +
                     "ACESSE FERRAMENTAS E INFORME OS PARAMENTROS DA CONEXÃO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cONFIGURAÇÃODOBANCODEDADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracaoBancoDados configuracaoBancoDados = new frmConfiguracaoBancoDados();
            configuracaoBancoDados.ShowDialog();
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroDeCategoriaNovo categoriaNovo = new frmCadastroDeCategoriaNovo();
            categoriaNovo.ShowDialog();
        }

        private void sUBCATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria subCategoria = new frmCadastroSubCategoria();
            subCategoria.ShowDialog();
        }

        private void cATEGORIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria categoria = new frmConsultaCategoria();
            categoria.Show();
        }

        private void sUBCATEGORIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria subCategoria = new frmConsultaSubCategoria();
            subCategoria.Show();
        }

        private void uNIDADEDEMEDIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUniMedida uniMedida = new frmCadastroUniMedida();
            uniMedida.ShowDialog();
        }

        private void uNIDADEDEMEDIDAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUniMedida uniMedida = new frmConsultaUniMedida();
            uniMedida.Show();
        }

        private void cONDIÇÃODEPAGAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTipoPagamento tipoPagamento = new frmCadastroTipoPagamento();
            tipoPagamento.ShowDialog();
        }

        private void tIPODEPAGAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento tipoPagamento = new frmConsultaTipoPagamento();
            tipoPagamento.Show();
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadastroProduto = new frmCadastroProduto();
            cadastroProduto.ShowDialog();
        }

        private void pRODUTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto consultaProduto = new frmConsultaProduto();
            consultaProduto.Show();
        }

        private void bACKUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupRestore backupRestore = new frmBackupRestore();
            backupRestore.Show();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cliente = new frmCadastroCliente();
            cliente.ShowDialog();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCliente consultaCliente = new frmConsultaCliente();
            consultaCliente.Show();
        }

        private void fORNECEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor fornecedor = new frmCadastroFornecedor();
            fornecedor.ShowDialog();
        }

        private void fORNECEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor fornecedor = new frmConsultaFornecedor();
            fornecedor.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sair = MetroMessageBox.Show(this,"Deseja Relamente sair do sistema","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sOBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.Show();
        }

        private void cOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoCompra compra = new frmMovimentacaoCompra();
            compra.ShowDialog();
        }

        private void cOMPRAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCompra compra = new frmConsultaCompra();
            compra.Show();
        }
    }
}
