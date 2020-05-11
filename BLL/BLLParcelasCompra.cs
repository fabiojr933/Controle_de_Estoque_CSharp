using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;

namespace BLL
{
    public class BLLParcelasCompra
    {
        private DALConexao Conexao;
        public BLLParcelasCompra(DALConexao cx)
        {
            this.Conexao = cx;
        }
        //METEDO INCLUIR
        public void Incluir(ModeloParcelasCompra modelo)
        {
            if(modelo.Pco_cod <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }
            if (modelo.Pco_valor <= 0)
            {
                throw new Exception("o valor da parcela é obrigatorio");
            }
            DateTime data = DateTime.Now;
            if (modelo.Pco_datavecto.Year < data.Year)
            {
                throw new Exception("a data de pagamento da parcela é obrigatorio");
            }
            DALParcelasCompra compra = new DALParcelasCompra(Conexao);
            compra.Incluir(modelo);
        }

        //METEDO ALTERAR
        public void Alterar(ModeloParcelasCompra modelo)
        {
            if (modelo.Pco_cod <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }
            if (modelo.Pco_valor <= 0)
            {
                throw new Exception("o valor da parcela é obrigatorio");
            }
            DateTime data = DateTime.Now;
            if (modelo.Pco_datavecto.Year < data.Year)
            {
                throw new Exception("a data de pagamento da parcela é obrigatorio");
            }
            if (modelo.Pco_cod <= 0 )
            {
                throw new Exception("o codigo da compra é obrigatorio");
            }
            DALParcelasCompra compra = new DALParcelasCompra(Conexao);
            compra.Alterar(modelo);
        }

        //METEDO EXCLUIR
        public void Excluir(ModeloParcelasCompra modelo)
        {
            if (modelo.Pco_cod <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }
            if (modelo.Com_cod <= 0)
            {
                throw new Exception("o codigo da compra é obrigatorio");
            }
            DALParcelasCompra compra = new DALParcelasCompra(Conexao);
            compra.Excluir(modelo);
        }

        //METEDO EXCLUIR TODAS AS PARCELAS
        public void ExcluirTodasParcelas(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }
            
            DALParcelasCompra compra = new DALParcelasCompra(Conexao);
            compra.ExcluirTodasParcelas(codigo);
        }

        public DataTable Localizar(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }
            DALParcelasCompra compra = new DALParcelasCompra(Conexao);
            return compra.Localizar(codigo);
        }

        //CARREGA MODELO
        public ModeloParcelasCompra compraModeloParcela(int com_cod, int pco_cod)
        {
            if (com_cod <= 0 && pco_cod <= 0)
            {
                throw new Exception("o codigo da parcela é obrigatorio");
            }
            DALParcelasCompra compra = new DALParcelasCompra(Conexao);
            return compra.compraModeloParcela(com_cod, pco_cod);
        }


    }
}
