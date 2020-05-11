using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTipoPagamento
    {
        private int tpa_cod;
        private string tpa_nome;

        public int Tpa_cod { get => tpa_cod; set => tpa_cod = value; }
        public string Tpa_nome { get => tpa_nome; set => tpa_nome = value; }
    }
}
