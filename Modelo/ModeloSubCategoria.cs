using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSubCategoria
    {
        public ModeloSubCategoria()
        {
            this.cat_cod = 0;
            this.scat_cod = 0;
            this.scat_nome = "";
        }
        public ModeloSubCategoria(int scatCod, int catCod, String scatNome)
        {
            this.scat_cod = scatCod;
            this.cat_cod = catCod;
            this.scat_nome = scatNome;
        }

        private int scat_cod;
        private string scat_nome;
        private int cat_cod;

        public int Scat_cod { get => scat_cod; set => scat_cod = value; }
        public string Scat_nome { get => scat_nome; set => scat_nome = value; }
        public int Cat_cod { get => cat_cod; set => cat_cod = value; }
    }
}
