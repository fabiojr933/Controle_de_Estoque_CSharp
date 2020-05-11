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
    public class BLLUnidMedida
    {
        private DALConexao Conexao;
        
        public BLLUnidMedida(DALConexao cx)
        {
            this.Conexao = cx;
        }

        //METEDO PARA INSERIR
        public void Inserir(ModeloUndMedida modelo)
        {
            if (modelo.Umed_nome.Trim().Length == 0)
            {
                throw new Exception("O nome da Unidade é OBRIGATORIO");
            }
            modelo.Umed_nome = modelo.Umed_nome.ToUpper();
            DALUndMedida dao = new DALUndMedida(Conexao);
            dao.Inserir(modelo);
        }

        //METEDO PARA ALTERAR
        public void Alterar(ModeloUndMedida modelo)
        {
            if(modelo.Umed_cod <= 0)
            {
                throw new Exception("O codigo da Unidade é OBRIGATORIO");
            }
            if (modelo.Umed_nome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade é OBRIGATORIO");
            }
            modelo.Umed_nome = modelo.Umed_nome.ToUpper();
            DALUndMedida dao = new DALUndMedida(Conexao);
            dao.Alterar(modelo);
        }

        //METEDO EXCLUIR
        public void Excluir(int codigo)
        {
            DALUndMedida dao = new DALUndMedida(Conexao);
            dao.Excluir(codigo);
        }

        //LOCALIZAR 
        public DataTable Localizar(string valor)
        {
            DALUndMedida dao = new DALUndMedida(Conexao);
            return dao.Localizar(valor);
        }

        //CARREGAR TODAS AS UND MEDIDAS
        public ModeloUndMedida carregarUnidades(int codigo)
        {
            DALUndMedida dao = new DALUndMedida(Conexao);
            return dao.carregarUnidades(codigo);
        }

        //METEDO PARA VERIFICAR VALOR REPETIDO  //0 nao existe    //maior que 0 existe
        public int verificaUnidade(string valor)
        {
            DALUndMedida undMedida = new DALUndMedida(Conexao);
            return undMedida.verificaUnidade(valor);
        }
    }
}
