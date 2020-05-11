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
    public class BLLSubCategoria
    {
        private DALConexao conexao;

        public BLLSubCategoria( DALConexao cx)
        {
            this.conexao = cx;
        }
        //METEDO INCLUIR(SALVAR)
        public void Incluir(ModeloSubCategoria modelo)
        {
            if(modelo.Scat_nome.Trim().Length == 0)
            {
                throw new Exception("O nome da SubCategoria é OBRIGATORIO");
            }
            if(modelo.Cat_cod <= 0)
            {
                throw new Exception("O nome da Categoria é OBRIGATORIO");
            }
            modelo.Scat_nome = modelo.Scat_nome.ToUpper();
            modelo.Cat_cod = modelo.Cat_cod;
            DALSubCategoria daoSubCategoria = new DALSubCategoria(conexao);
            daoSubCategoria.Incluir(modelo);
        }

        //METEDO ALTERAR(EDITAR)
        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.Scat_nome.Trim().Length == 0)
            {
                throw new Exception("O nome da SubCategoria é OBRIGATORIO");
            }
            if (modelo.Cat_cod <= 0)
            {
                throw new Exception("O nome da Categoria é OBRIGATORIO");
            }
            if (modelo.Scat_cod <= 0)
            {
                throw new Exception("O codigo da Categoria é OBRIGATORIO");
            }
            modelo.Scat_nome = modelo.Scat_nome.ToUpper();
            modelo.Cat_cod = modelo.Cat_cod;
            DALSubCategoria daoSubCategoria = new DALSubCategoria(conexao);
            daoSubCategoria.Alterar(modelo);
        }

        //METEDO EXCLUIR(DELETAR)
        public void Excluir(int codigo)
        {
            DALSubCategoria daoSubCategoria = new DALSubCategoria(conexao);
            daoSubCategoria.Excluir(codigo);
        }

        //METEDO LOCALIZAR(PESQUIZAR)
        public DataTable Localizar(string valor)
        {
            DALSubCategoria daoSubCategoria = new DALSubCategoria(conexao);
            return daoSubCategoria.Localizar(valor);
        }

        //METEDO LISTAR TODOS
        public ModeloSubCategoria CarregarModeloSubCategoria(int codigo)
        {
            DALSubCategoria daoSubCategoria = new DALSubCategoria(conexao);
            return daoSubCategoria.CarregarModeloSubCategoria(codigo);
        }

        //LOCALIZAR POR CATEGORIA
        public DataTable LocalizaPorCategoria(int codigo)
        {
            DALSubCategoria categoria = new DALSubCategoria(conexao);
            return categoria.LocalizaPorCategoria(codigo);
        }
    }
}
