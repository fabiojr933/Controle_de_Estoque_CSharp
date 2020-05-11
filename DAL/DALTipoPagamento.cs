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
    public class DALTipoPagamento
    {
        private DALConexao conexao;

        public DALTipoPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        //METEDO SALVAR
        public void Incluir(ModeloTipoPagamento modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into tipopagamento (tpa_nome) values(@tpa_nome)";
                cmd.Parameters.AddWithValue("@tpa_nome",modelo.Tpa_nome);
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

        //METEDO PARA ALTERAR
        public void Alterar(ModeloTipoPagamento modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update tipopagamento set tpa_nome = @tpa_nome where tpa_cod = @tpa_cod";
                cmd.Parameters.AddWithValue("tpa_nome", modelo.Tpa_nome);
                cmd.Parameters.AddWithValue("tpa_cod",modelo.Tpa_cod);
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

        //METEDO PARA Deletar
        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from tipopagamento where tpa_cod ="+codigo;
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Err ao deletar " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(string valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from tipopagamento where tpa_nome like '%" + valor + "%'order by tpa_cod asc", conexao.ObjetoConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CARREGAR TODAS OS TIPOS PAGAMENTOS
        public ModeloTipoPagamento carregarTipoPagamento(int codigo)
        {
            ModeloTipoPagamento tpaPagamento = new ModeloTipoPagamento();
            try
            {
               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from tipopagamento where tpa_cod = @tpa_cod order by tpa_cod asc";
                cmd.Parameters.AddWithValue("@tpa_cod", codigo);
                conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    tpaPagamento.Tpa_cod = Convert.ToInt32(dr["tpa_cod"]);
                    tpaPagamento.Tpa_nome = Convert.ToString(dr["tpa_nome"]);
                }
                return tpaPagamento;
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
    }
}
