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
using DAL;

namespace ControleEstoque
{
    public partial class frmConfiguracaoBancoDados : MetroFramework.Forms.MetroForm
    {
        public frmConfiguracaoBancoDados()
        {
            InitializeComponent();
        }

        private void frmConfiguracaoBancoDados_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(78, 109, 156);

            try
            {
                StreamReader arquivo = new StreamReader("configuracaoBanco.txt");
                txtServidor.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();
            }
            catch (SqlException )
            {
                MetroFramework.MetroMessageBox.Show(this,"Falha ao se conectar com banco de dados","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Falha ao se conectar com banco de dados" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao.servidor = txtServidor.Text;
                DadosDaConexao.banco = txtBanco.Text;
                DadosDaConexao.usuario = txtUsuario.Text;
                DadosDaConexao.senha = txtSenha.Text;

                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MetroFramework.MetroMessageBox.Show(this,"Conexao efetuada com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException )
            {
                MetroFramework.MetroMessageBox.Show(this, "Falha ao se conectar com banco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Falha ao se conectar com banco" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("configuracaoBanco.txt", false);
                arquivo.WriteLine(txtServidor.Text);
                arquivo.WriteLine(txtBanco.Text);
                arquivo.WriteLine(txtUsuario.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();
                MetroFramework.MetroMessageBox.Show(this, "Configuração salvo com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Falha ao salvar as configurações" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
