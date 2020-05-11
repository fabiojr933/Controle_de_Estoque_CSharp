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
    public class BLLCompra
    {
        private DALConexao Conexao;
        public BLLCompra(DALConexao cx)
        {
            this.Conexao = cx;
        }

        //METEDO INSIRIR
        public void Incluir(ModeloCompra modelo)
        {
            if(modelo.Com_total <= 0)
            {
                throw new Exception("O valor da compra de se informado");
            }
            if (modelo.For_cod <= 0)
            {
                throw new Exception("O codogo do fornecedor deve se informado");
            }
            if (modelo.Com_nparcelas <= 0)
            {
                throw new Exception("O numeros de parcelas deve se informado");
            }
            //if (modelo.Com_data != DateTime.Now)
            //{
            //    throw new Exception("A data da compra não corresponde a dada atual");
            //}
            DALCompra compra = new DALCompra(Conexao);
            compra.Incluir(modelo);
        }

        //METEDO ALTERAR
        public void Alterar(ModeloCompra modelo)
        {
            if (modelo.Com_cod <= 0)
            {
                throw new Exception("Selecione um codigo");
            }
            if (modelo.Com_total <= 0)
            {
                throw new Exception("O valor da compra de se informado");
            }
            if (modelo.For_cod <= 0)
            {
                throw new Exception("O codogo do fornecedor deve se informado");
            }
            if (modelo.Com_nparcelas <= 0)
            {
                throw new Exception("O numeros de parcelas deve se informado");
            }
            if (modelo.Com_data != DateTime.Now)
            {
                throw new Exception("Adata da compra não corresponde a dada atual");
            }
            DALCompra compra = new DALCompra(Conexao);
            compra.Alterar(modelo);
        }

        //METEDO EXCLUIR
        public void Excluir(int codigo)
        {
            DALCompra compra = new DALCompra(Conexao);
            compra.Excluir(codigo);
        }

        public DataTable LocalizarPorFornecedor(int Codigo)
        {
            DALCompra compra = new DALCompra(Conexao);
            return compra.LocalizarPorFornecedor(Codigo);
        }


        public DataTable LocalizarPorNome(string nome)
        {
            DALCompra compra = new DALCompra(Conexao);
            return compra.LocalizarPorNome(nome);
        }


        public DataTable LocalizarPorData(DateTime dataInicial, DateTime dataFinal)
        {
            DALCompra compra = new DALCompra(Conexao);
            return compra.LocalizarPorData(dataInicial,dataFinal);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra compra = new DALCompra(Conexao);
            return compra.CarregaModeloCompra(codigo);
        }

        public DataTable LocalizarPorParcela()
        {
            DALCompra compra = new DALCompra(Conexao);
            return compra.LocalizarPorParcela();
        }
    }
}
