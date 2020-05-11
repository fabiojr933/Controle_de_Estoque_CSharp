using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelasVenda
    {
        private int ven_cod;
        private int pve_cod;
        private Double pve_valor;
        private DateTime pve_datapagto;
        private DateTime pve_datavecto;

        public int Ven_cod { get => ven_cod; set => ven_cod = value; }
        public int Pve_cod { get => pve_cod; set => pve_cod = value; }
        public double Pve_valor { get => pve_valor; set => pve_valor = value; }
        public DateTime Pve_datapagto { get => pve_datapagto; set => pve_datapagto = value; }
        public DateTime Pve_datavecto { get => pve_datavecto; set => pve_datavecto = value; }
    }
}
