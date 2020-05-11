using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLParcelasVendas
    {
        private DALConexao Conexao;
        public BLLParcelasVendas(DALConexao cx)
        {
            this.Conexao = cx;
        }
        //METEDO INCLUIR
        public void Incluir(ModeloParcelasVenda modelo)
        {
            if (modelo.Pve_cod <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }
            if (modelo.Pve_valor <= 0)
            {
                throw new Exception("o valor da parcela é obrigatorio");
            }
            DateTime data = DateTime.Now;
            if (modelo.Pve_datavecto.Year < data.Year)
            {
                throw new Exception("a data de pagamento da parcela é obrigatorio");
            }
            DALParcelasVendas compra = new DALParcelasVendas(Conexao);
            compra.Incluir(modelo);
        }

        //METEDO ALTERAR
        public void Alterar(ModeloParcelasVenda modelo)
        {
            if (modelo.Pve_cod <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }
            if (modelo.Pve_valor <= 0)
            {
                throw new Exception("o valor da parcela é obrigatorio");
            }
            DateTime data = DateTime.Now;
            if (modelo.Pve_datavecto.Year < data.Year)
            {
                throw new Exception("a data de pagamento da parcela é obrigatorio");
            }
            if (modelo.Ven_cod <= 0)
            {
                throw new Exception("o codigo da venda é obrigatorio");
            }
            DALParcelasVendas compra = new DALParcelasVendas(Conexao);
            compra.Alterar(modelo);
        }

        //METEDO EXCLUIR
        public void Excluir(ModeloParcelasVenda modelo)
        {
            if (modelo.Pve_cod <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }
            if (modelo.Ven_cod <= 0)
            {
                throw new Exception("o codigo da venda é obrigatorio");
            }
            DALParcelasVendas compra = new DALParcelasVendas(Conexao);
            compra.Excluir(modelo);
        }

        //METEDO EXCLUIR TODAS AS PARCELAS
        public void ExcluirTodasParcelas(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }

            DALParcelasVendas compra = new DALParcelasVendas(Conexao);
            compra.ExcluirTodasParcelas(codigo);
        }

        public DataTable Localizar(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }
            DALParcelasVendas compra = new DALParcelasVendas(Conexao);
            return compra.Localizar(codigo);
        }

        //CARREGA MODELO
        public ModeloParcelasVenda compraModeloParcela(int ven_cod, int pve_cod)
        {
            if (pve_cod <= 0 && ven_cod <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }
            BLLParcelasVendas compra = new BLLParcelasVendas(Conexao);
            return compra.compraModeloParcela(pve_cod, ven_cod);
        }
    }
}
