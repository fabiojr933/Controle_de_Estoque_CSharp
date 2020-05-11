using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace BBL
{
    public class BLLProduto
    {
        private DALConexao conexao; 

        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        //METEDO INCLUIR
        public void Incluir(ModeloProduto modelo)
        {
            if (modelo.Pro_nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigadorio");
            }
            if (modelo.Pro_descricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigadorio");
            }
            if (modelo.Pro_valorvenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigadorio");
            }
            if (modelo.Pro_qtde <= 0)
            {
                throw new Exception("A quantidade de venda do produto é obrigadorio");
            }
            if (modelo.Umed_cod <= 0)
            {
                throw new Exception("A Unidade de medida é obrigadorio");
            }
            if (modelo.Cat_cod <= 0)
            {
                throw new Exception("A categoria é obrigadorio");
            }
            if (modelo.Scat_cod <= 0)
            {
                throw new Exception("A subCateria é obrigadorio");
            }
            DALProduto produto = new DALProduto(conexao);
            produto.Incluir(modelo);

        }
        //METEDO EXCLUIR
        public void Excluir(int codigo)
        {
            DALProduto produto = new DALProduto(conexao);
            produto.Excluir(codigo);
        }

        //METEDO ALTERAR
        public void Alterar(ModeloProduto modelo)
        {
            if (modelo.Pro_cod <= 0)
            {
                throw new Exception("O codigo do produto é obrigatorio");
            }
            if (modelo.Pro_nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigadorio");
            }
            if (modelo.Pro_descricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigadorio");
            }
            if (modelo.Pro_valorvenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigadorio");
            }
            if (modelo.Pro_qtde <= 0)
            {
                throw new Exception("A quantidade de venda do produto é obrigadorio");
            }
            if (modelo.Umed_cod <= 0)
            {
                throw new Exception("A Unidade de medida é obrigadorio");
            }
            if (modelo.Cat_cod <= 0)
            {
                throw new Exception("A categoria é obrigadorio");
            }
            if (modelo.Scat_cod <= 0)
            {
                throw new Exception("A subCateria é obrigadorio");
            }
            DALProduto produto = new DALProduto(conexao);
            produto.Alterar(modelo);
        }

        //METEDO LOCALIZAR
        public DataTable Localizar(string valor)
        {
            DALProduto produto = new DALProduto(conexao);
            return produto.Localizar(valor);
        }

        //METEDO CARREGAR PRODUTOS
        public ModeloProduto carregarModeloProdutos(int codigo)
        {
            DALProduto produto = new DALProduto(conexao);
            return produto.carregarModeloProdutos(codigo);
        }
    }
}
