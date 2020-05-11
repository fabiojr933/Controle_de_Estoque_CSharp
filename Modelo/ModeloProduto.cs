using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        public ModeloProduto()
        {
            this.pro_cod = 0;
            this.pro_nome = "";
            this.pro_descricao = "";
            //  this.pro_foto = "";
            this.pro_valorpago = 0;
            this.pro_valorvenda = 0;
            this.pro_qtde = 0;
            this.umed_cod = 0;
            this.cat_cod = 0;
            this.scat_cod = 0;
        }

        public ModeloProduto(int pro_cod, string pro_nome, string pro_descricao, string pro_foto, double pro_valorpago, double pro_valorvenda, float pro_qtde, int umed_cod, int cat_cod, int scat_cod)
        {
            this.pro_cod = pro_cod;
            this.pro_nome = pro_nome;
            this.pro_descricao = pro_descricao;
            this.CarregaImage(pro_foto);
            this.pro_valorpago = pro_valorpago;
            this.pro_valorvenda = pro_valorvenda;
            this.pro_qtde = pro_qtde;
            this.umed_cod = umed_cod;
            this.cat_cod = cat_cod;
            this.scat_cod = scat_cod;
        }

        public ModeloProduto(int pro_cod, string pro_nome, string pro_descricao, byte[] pro_foto, double pro_valorpago, double pro_valorvenda, float pro_qtde, int umed_cod, int cat_cod, int scat_cod)
        {
            this.pro_cod = pro_cod;
            this.pro_nome = pro_nome;
            this.pro_descricao = pro_descricao;
            this.pro_foto = pro_foto;
            this.pro_valorpago = pro_valorpago;
            this.pro_valorvenda = pro_valorvenda;
            this.pro_qtde = pro_qtde;
            this.umed_cod = umed_cod;
            this.cat_cod = cat_cod;
            this.scat_cod = scat_cod;
        }

        private int pro_cod;
        private string pro_nome;
        private string pro_descricao;
        private byte[] pro_foto;
        private Double pro_valorpago;
        private Double pro_valorvenda;
        private float pro_qtde;
        private int umed_cod;
        private int cat_cod;
        private int scat_cod;

        public int Pro_cod { get => pro_cod; set => pro_cod = value; }
        public string Pro_nome { get => pro_nome; set => pro_nome = value; }
        public string Pro_descricao { get => pro_descricao; set => pro_descricao = value; }       
        public double Pro_valorpago { get => pro_valorpago; set => pro_valorpago = value; }
        public double Pro_valorvenda { get => pro_valorvenda; set => pro_valorvenda = value; }
        public float Pro_qtde { get => pro_qtde; set => pro_qtde = value; }
        public int Umed_cod { get => umed_cod; set => umed_cod = value; }
        public int Cat_cod { get => cat_cod; set => cat_cod = value; }
        public int Scat_cod { get => scat_cod; set => scat_cod = value; }
        public byte[] Pro_foto { get => pro_foto; set => pro_foto = value; }



        public void CarregaImage(string imgCaminho)
        {
            try
            {             
                if (imgCaminho != null)
                {
                   // return;
                    FileInfo arqImagem = new FileInfo(imgCaminho);
                    FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                    this.pro_foto = new byte[Convert.ToInt32(arqImagem.Length)];
                    int iBytesRead = fs.Read(this.pro_foto, 0, Convert.ToInt32(arqImagem.Length));
                    fs.Close();
                }                
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu algum erro com a IMAGEM! " + ex.Message); ;
            }
        }
    }
}
