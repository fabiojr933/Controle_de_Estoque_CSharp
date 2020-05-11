using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
        public ModeloCategoria()
        {
            this.cat_cod = 0;
            this.cat_nome = "";
        }
        public ModeloCategoria(int CatCod, string catNome)
        {
            this.cat_cod = CatCod;
            this.cat_nome = catNome;
        }

        private int cat_cod;
        private string cat_nome;

        public int Cat_cod { get => cat_cod; set => cat_cod = value; }
        public string Cat_nome { get => cat_nome; set => cat_nome = value; }
    }
}
