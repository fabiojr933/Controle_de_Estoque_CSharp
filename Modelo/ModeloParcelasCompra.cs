using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelasCompra
    {
        private int pco_cod;
        private Double pco_valor;
        private DateTime pco_datapagto;
        private DateTime pco_datavecto;
        private int com_cod;

        public int Pco_cod { get => pco_cod; set => pco_cod = value; }
        public double Pco_valor { get => pco_valor; set => pco_valor = value; }
        public DateTime Pco_datapagto { get => pco_datapagto; set => pco_datapagto = value; }
        public DateTime Pco_datavecto { get => pco_datavecto; set => pco_datavecto = value; }
        public int Com_cod { get => com_cod; set => com_cod = value; }
    }
}
