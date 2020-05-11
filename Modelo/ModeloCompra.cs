using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCompra
    {


        private int com_cod;
        private DateTime com_data;
        private int com_nfiscal;
        private Double com_total;
        private int com_nparcelas;
        private string com_status;
        private int for_cod;
        private int tpa_cod;


        public int Com_cod { get => com_cod; set => com_cod = value; }
        public DateTime Com_data { get => com_data; set => com_data = value; }
        public int Com_nfiscal { get => com_nfiscal; set => com_nfiscal = value; }
        public double Com_total { get => com_total; set => com_total = value; }
        public int Com_nparcelas { get => com_nparcelas; set => com_nparcelas = value; }
        public string Com_status { get => com_status; set => com_status = value; }
        public int For_cod { get => for_cod; set => for_cod = value; }
        public int Tpa_cod { get => tpa_cod; set => tpa_cod = value; }
    }
}
