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
    public class DALParcelasCompra
    {
        private DALConexao Conexao;
        public DALParcelasCompra(DALConexao cx)
        {
            this.Conexao = cx;
        }
        //METEDO INCLUIR
        public void Incluir(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "insert into parcelascompra (pco_cod,com_cod,pco_datavecto,pco_valor)" +
                    " values(@pco_cod,@com_cod,@pco_datavecto,@pco_valor) ";
                cmd.Parameters.AddWithValue("@pco_cod", modelo.Pco_cod);
                cmd.Parameters.AddWithValue("@com_cod", modelo.Com_cod);
                cmd.Parameters.Add("@pco_datavecto",System.Data.SqlDbType.Date);
                cmd.Parameters["@pco_datavecto"].Value = modelo.Pco_datavecto;                            
                cmd.Parameters.AddWithValue("@pco_valor", modelo.Pco_valor);
                Conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        //METEDO ALTERAR
        public void Alterar(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "update parcelascompra set pco_datapagto = @pco_datapagto" +
                    "pco_datavecto = @pco_datavecto, pco_valor = @pco_valor where com_cod = @com_cod " +
                    "and pco_cod = @pco_cod";

                cmd.Parameters.Add("@pco_datapagto", System.Data.SqlDbType.Date);                
                if (modelo.Pco_datapagto == null)
                {
                    cmd.Parameters["@pco_datapagto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@pco_datapagto"].Value = modelo.Pco_datapagto;
                }
                cmd.Parameters["@pco_datavecto"].Value = modelo.Pco_datavecto;
                cmd.Parameters.AddWithValue("@pco_valor", modelo.Pco_valor);
                cmd.Parameters.AddWithValue("@com_cod", modelo.Com_cod);
                cmd.Parameters.AddWithValue("@pco_cod", modelo.Pco_cod);
                Conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        //METEDO EXCLUIR
        public void Excluir(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "delete from parcelascompra where com_cod = @com_cod and pco_cod = @pco_cod";
                cmd.Parameters.AddWithValue("@com_cod", modelo.Com_cod);
                cmd.Parameters.AddWithValue("@pco_cod", modelo.Pco_cod);
                Conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        //METEDO EXCLUIR todos
        public void ExcluirTodasParcelas(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "delete from parcelascompra where com_cod = @com_cod";
                cmd.Parameters.AddWithValue("@com_cod", codigo);
                Conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
        
        public DataTable Localizar(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from parcelascompra where com_cod =" + codigo.ToString(), Conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CARREGA MODELO
        public ModeloParcelasCompra compraModeloParcela(int com_cod, int pco_cod)
        {
            try
            {
                ModeloParcelasCompra compra = new ModeloParcelasCompra();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "select * from parcelascompra where pco_cod = @pco_cod " +
                    "and com_cod = @com_cod";
                cmd.Parameters.AddWithValue("@pco_cod",pco_cod);
                cmd.Parameters.AddWithValue("@com_cod",com_cod);
                Conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    compra.Pco_cod = pco_cod;
                    compra.Com_cod = com_cod;
                    compra.Pco_datapagto = Convert.ToDateTime(registro["pco_datapagto"]);
                    compra.Pco_datavecto = Convert.ToDateTime(registro["pco_datavecto"]);
                    compra.Pco_valor = Convert.ToDouble(registro["pco_valor"]);
                }
                return compra;
            }            
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

    }
}
