using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;


namespace BLL
{
    public class BLLItensCompra
    {
        private DALConexao Conexao;

        public BLLItensCompra(DALConexao cx)
        {
            this.Conexao = cx;
        }

        //METEDO INSERIR
        public void Inserir(ModeloItensCompra modelo)
        {
            //if (modelo.Com_cod <= 0)
            //{
            //    throw new Exception("o codigo da compra é obrigatorio");
            //}
            if (modelo.Itc_cod <= 0)
            {
                throw new Exception("o codigo do item da compra é obrigatorio");
            }
            if (modelo.Itc_qtde <= 0)
            {
                throw new Exception("Informe uma quantidade");
            }
            if (modelo.Itc_valor <= 0)
            {
                throw new Exception("o valor do produto é obrigatorio");
            }
            if (modelo.Pro_cod <= 0)
            {
                throw new Exception("o codigo do produto é obrigatorio");
            }
            DALItensCompra compra = new DALItensCompra(Conexao);
            compra.Inserir(modelo);
        }

        //METEDO ALTERAR
        public void Alterar(ModeloItensCompra modelo)
        {
            if (modelo.Com_cod <= 0)
            {
                throw new Exception("o codigo do produto é obrigatorio");
            }
            if (modelo.Itc_cod <= 0)
            {
                throw new Exception("o codigo do item da compra é obrigatorio");
            }
            if (modelo.Itc_qtde <= 0)
            {
                throw new Exception("Informe uma quantidade");
            }
            if (modelo.Itc_valor <= 0)
            {
                throw new Exception("o valor do produto é obrigatorio");
            }
            if (modelo.Pro_cod <= 0)
            {
                throw new Exception("o codigo do produto é obrigatorio");
            }
            DALItensCompra compra = new DALItensCompra(Conexao);
            compra.Alterar(modelo);
        }

        //METEDO EXCLUIR
        public void Excluir(ModeloItensCompra modelo)
        {
            if (modelo.Com_cod <= 0)
            {
                throw new Exception("o codigo da compra é obrigatorio");
            }
            if (modelo.Itc_cod <= 0)
            {
                throw new Exception("o codigo do item da compra é obrigatorio");
            }          
            if (modelo.Pro_cod <= 0)
            {
                throw new Exception("o codigo do produto é obrigatorio");
            }
            DALItensCompra compra = new DALItensCompra(Conexao);
            compra.Excluir(modelo);
        }

        //METEDO LOCALIZAR
        public DataTable Localizar(int codigo)
        {
            DALItensCompra compra = new DALItensCompra(Conexao);
            return compra.Localizar(codigo);
        }

        //METEDO CARREGA MODELO
        public ModeloItensCompra CarregaModeloItensCompra(int Itc_cod, int Com_cod, int Pro_cod)
        {
            DALItensCompra compra = new DALItensCompra(Conexao);
            return compra.CarregaModeloItensCompra(Itc_cod,Com_cod, Pro_cod);
        }
    }
}
