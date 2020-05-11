using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItensCompra
    {
        private int itc_cod;
        private Double itc_qtde;
        private Double itc_valor;
        private int com_cod;
        private int pro_cod;

        public int Itc_cod { get => itc_cod; set => itc_cod = value; }
        public double Itc_qtde { get => itc_qtde; set => itc_qtde = value; }
        public double Itc_valor { get => itc_valor; set => itc_valor = value; }
        public int Com_cod { get => com_cod; set => com_cod = value; }
        public int Pro_cod { get => pro_cod; set => pro_cod = value; }
    }
}
