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
using Ferramentas; 

namespace View
{
    public partial class frmBackupRestore : MetroFramework.Forms.MetroForm
    {
        public frmBackupRestore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog caminho = new SaveFileDialog();
                caminho.Filter = "Backup Files|*.bak";
                caminho.ShowDialog();
                if (caminho.FileName != "")
                {
                    string nomeBanco = DadosDaConexao.banco;
                    string localBackup = caminho.FileName;
                    string conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;" +
                        "User=" + DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, caminho.FileName);
                    MessageBox.Show("Backup realizado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Realizar o Backup " + ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog caminho = new OpenFileDialog();
                caminho.Filter = "Backup Files|*.bak";
                caminho.ShowDialog();
                if (caminho.FileName != "")
                {
                    string nomeBanco = DadosDaConexao.banco;
                    string localBackup = caminho.FileName;
                    string conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;" +
                        "User=" + DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, caminho.FileName);
                    MessageBox.Show("Backup restaurado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar o Backup " + ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
