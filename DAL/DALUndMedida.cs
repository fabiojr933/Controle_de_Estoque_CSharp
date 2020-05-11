using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALUndMedida
    {
        private DALConexao conexao;

        public DALUndMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        //METEDO PARA INSERIR
        public void Inserir(ModeloUndMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into undmedida (umed_nome) values (@umed_nome)";
                cmd.Parameters.AddWithValue("@umed_nome",modelo.Umed_nome);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ops Ocorreu alugum erro " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        //METEDO PARA ALTERAR
        public void Alterar(ModeloUndMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update undmedida set umed_nome = @umed_nome where umed_cod = @umed_cod";
                cmd.Parameters.AddWithValue("@umed_nome",modelo.Umed_nome);
                cmd.Parameters.AddWithValue("@umed_cod", modelo.Umed_cod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        //METEDO EXCLUIR
        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from undmedida where umed_cod = @umed_cod";
                cmd.Parameters.AddWithValue("@umed_cod",codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        //LOCALIZAR 
        public DataTable Localizar(string valor)
        {
            try
            {
                  DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from undmedida where umed_nome like '%" + valor + "%'order by umed_cod asc", conexao.ObjetoConexao);
            da.Fill(tabela);
            return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); ;
            }
        }

        //CARREGAR TODAS AS UND MEDIDAS
        public ModeloUndMedida carregarUnidades(int codigo)
        {
            try
            {
                ModeloUndMedida undMedida = new ModeloUndMedida();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from undmedida where umed_cod = @umed_cod order by umed_cod asc";
                cmd.Parameters.AddWithValue("@umed_cod", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    undMedida.Umed_cod = Convert.ToInt32(registro["umed_cod"]);
                    undMedida.Umed_nome = Convert.ToString(registro["umed_nome"]);
                }
                return undMedida;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        //METEDO PARA VERIFICAR VALOR REPETIDO  //0 nao existe    //maior que 0 existe
        public int verificaUnidade(string valor)
        {
            try
            {
                int r = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from undmedida where umed_nome = @umed_nome";
                cmd.Parameters.AddWithValue("@umed_nome",valor);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["umed_cod"]);
                }
                return r;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro! " + ex.Message); ;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
