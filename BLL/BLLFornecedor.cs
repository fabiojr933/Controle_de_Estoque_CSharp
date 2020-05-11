using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLFornecedor
    {
        private DALConexao Conexao;

        public BLLFornecedor(DALConexao cx)
        {
            this.Conexao = cx;
        }

        //METEDO INSERIR NO BANCO DE DADOS
        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.For_nome.Trim().Length == 0)
            {
                throw new Exception(" O nome é Obrigatorio ");
            }
            if (modelo.For_cnpj.Trim().Length == 0)
            {
                throw new Exception(" O CNPJ é Obrigatorio ");
            }
            if (modelo.For_endereco.Trim().Length == 0)
            {
                throw new Exception(" O Endereço é Obrigatorio");
            }
            if (modelo.For_email.Trim().Length == 0)
            {
                throw new Exception(" O email é Obrigatorio ");
            }
            DALFornecedor fornecedor = new DALFornecedor(Conexao);
            fornecedor.Incluir(modelo);

        }

        // METEDO EDITAR CATEGORIA
        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.For_cod <= 0)
            {
                throw new Exception("SELECIONE UM FORNECEDOR");
            }
            if (modelo.For_nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigadorio");
            }
            DALFornecedor fornecedor = new DALFornecedor(Conexao);
            fornecedor.Alterar(modelo);
        }

        //METEDO EXCLUIR CATEGORIA
        public void Excluir(int codigo)
        {
            if(codigo <= 0)
            {
                throw new Exception(" Selecione um codigo ");
            }
            DALFornecedor fornecedor = new DALFornecedor(Conexao);
            fornecedor.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        {
            DALFornecedor fornecedor = new DALFornecedor(Conexao);
            return fornecedor.Localizar(valor);            
        }

        public ModeloFornecedor carregaModeloCategoria(int codigo)
        {
            DALFornecedor fornecedor = new DALFornecedor(Conexao);
            return fornecedor.carregaModeloClienteCod(codigo);
        }

    }
}
