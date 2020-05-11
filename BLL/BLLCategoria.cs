using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;

namespace BBL
{
    public class BLLCategoria
    {
        private DALConexao conexao;

        public BLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo) //METEDO INSERIR CATEGORIA
        {
            if(modelo.Cat_nome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é OBRIGATORIO");
            }
            modelo.Cat_nome = modelo.Cat_nome.ToUpper();
            DALCategoria daoCategoria = new DALCategoria(conexao);
            daoCategoria.Incluir(modelo);
        }

        public void Alterar(ModeloCategoria modelo) // METEDO EDITAR CATEGORIA
        {
            if (Convert.ToInt32(modelo.Cat_cod) <= 0)
            {
                throw new Exception("O codigo da categoria é OBRIGATORIO");
            }
            if (modelo.Cat_nome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é OBRIGATORIO");
            }
            modelo.Cat_nome = modelo.Cat_nome.ToUpper();
            DALCategoria daoCategoria = new DALCategoria(conexao);
            daoCategoria.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCategoria daoCategoria = new DALCategoria(conexao);
            daoCategoria.Excluir(codigo);
        } //EXCLUIR CATEGORIA

        public DataTable Localizar(string valor)
        {
            DALCategoria daoCategoria = new DALCategoria(conexao);
            return daoCategoria.Localizar(valor);
        } // METEDO LOCALIZAR CATEGORIA

        public ModeloCategoria carregaModeloCategoria(int codigo)
        {
            DALCategoria daoCategoria = new DALCategoria(conexao);
            return daoCategoria.carregaModeloCategoria(codigo);
        } //LISTAR TODAS AS CATEGORIAS
    }
}
