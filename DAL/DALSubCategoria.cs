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
    public class DALSubCategoria
    {
        private DALConexao conexao;

        public DALSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }
        //METEDO INCLUIR(SALVAR)
        public void Incluir(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into subcategoria(scat_nome,cat_cod) values(@scat_nome,@cat_cod); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@scat_nome", modelo.Scat_nome);
                cmd.Parameters.AddWithValue("@cat_cod", modelo.Cat_cod);                
                conexao.Conectar();
                modelo.Scat_cod = Convert.ToInt32(cmd.ExecuteScalar());
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

        //METEDO ALTERAR(EDITAR)
        public void Alterar(ModeloSubCategoria modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update subcategoria set scat_nome = @scat_nome, cat_cod = @cat_cod where scat_cod = @scat_cod";
                cmd.Parameters.AddWithValue("@scat_nome", modelo.Scat_nome);
                cmd.Parameters.AddWithValue("@cat_cod", modelo.Cat_cod);
                cmd.Parameters.AddWithValue("@scat_cod", modelo.Scat_cod);               
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

        //METEDO EXCLUIR(DELETAR)
        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from subcategoria where scat_cod = @scat_cod";
                cmd.Parameters.AddWithValue("@scat_cod", codigo);
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

        //METEDO LOCALIZAR(PESQUIZAR)
        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select sub.scat_cod, sub.scat_nome, cat.cat_cod, cat.cat_nome" +
                " from subcategoria sub inner join categoria cat on sub.cat_cod = cat.cat_cod" +
                "  where sub.scat_nome like '%" + valor + "%'order by scat_cod asc", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //METEDO LISTAR TODOS
        public ModeloSubCategoria CarregarModeloSubCategoria(int codigo)
        {
            try
            {
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from subcategoria where scat_cod = @scat_cod";
                cmd.Parameters.AddWithValue("@scat_cod", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo.Scat_cod = Convert.ToInt32(registro["scat_cod"]);
                    modelo.Scat_nome = Convert.ToString(registro["scat_nome"]);
                    modelo.Cat_cod = Convert.ToInt32(registro["cat_cod"]);                    
                }
                return modelo;
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


        //LOCALIZAR POR CATEGORIA
        public DataTable LocalizaPorCategoria(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select sub.scat_cod, sub.scat_nome, cat.cat_cod, cat.cat_nome" +
                " from subcategoria sub inner join categoria cat on sub.cat_cod = cat.cat_cod" +
                "  where cat.cat_cod ="+codigo, conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao buscar " + ex.Message);
            }
        }
    }
}
