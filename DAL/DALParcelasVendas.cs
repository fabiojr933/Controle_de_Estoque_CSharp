using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALParcelasVendas
    {
        private DALConexao Conexao;
        public DALParcelasVendas(DALConexao cx)
        {
            this.Conexao = cx;
        }
        //METEDO INCLUIR
        public void Incluir(ModeloParcelasVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "insert into parcelasvenda (pve_cod,ven_cod,pve_datavecto,pve_valor)" +
                    " values(@pve_cod,@ven_cod,@pve_datavecto,@pve_valor) ";
                cmd.Parameters.AddWithValue("@pve_cod", modelo.Pve_cod);
                cmd.Parameters.AddWithValue("@ven_cod", modelo.Ven_cod);
                cmd.Parameters.Add("@pve_datavecto", System.Data.SqlDbType.Date);
                cmd.Parameters["@pve_datavecto"].Value = modelo.Pve_datavecto;
                cmd.Parameters.AddWithValue("@pve_valor", modelo.Pve_valor);
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
        public void Alterar(ModeloParcelasVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "update ParcelasVenda set pve_datapagto = @pve_datapagto" +
                    "pve_datavecto = @pve_datavecto, pve_valor = @pve_valor where ven_cod = @ven_cod " +
                    "and pve_cod = @pve_cod";

                cmd.Parameters.Add("@pve_datapagto", System.Data.SqlDbType.Date);
                if (modelo.Pve_datapagto == null)
                {
                    cmd.Parameters["@pve_datapagto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@pve_datapagto"].Value = modelo.Pve_datapagto;
                }
                cmd.Parameters["@pve_datavecto"].Value = modelo.Pve_datavecto;
                cmd.Parameters.AddWithValue("@pve_valor", modelo.Pve_valor);
                cmd.Parameters.AddWithValue("@ven_cod", modelo.Ven_cod);
                cmd.Parameters.AddWithValue("@pve_cod", modelo.Pve_cod);
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
        public void Excluir(ModeloParcelasVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "delete from ParcelasVenda where ven_cod = @ven_cod and pve_cod = @pve_cod";
                cmd.Parameters.AddWithValue("@ven_cod", modelo.Ven_cod);
                cmd.Parameters.AddWithValue("@pve_cod", modelo.Pve_cod);
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
                cmd.CommandText = "delete from ParcelasVenda where ven_cod = @ven_cod";
                cmd.Parameters.AddWithValue("@ven_cod", codigo);
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
                SqlDataAdapter da = new SqlDataAdapter("select * from ParcelasVenda where ven_cod =" + codigo.ToString(), Conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CARREGA MODELO
        public ModeloParcelasVenda compraModeloParcela(int ven_cod, int pve_cod)
        {
            try
            {
                ModeloParcelasVenda compra = new ModeloParcelasVenda();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "select * from ParcelasVenda where pve_cod = @pve_cod " +
                    "and ven_cod = @ven_cod";
                cmd.Parameters.AddWithValue("@pve_cod", pve_cod);
                cmd.Parameters.AddWithValue("@ven_cod", ven_cod);
                Conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    compra.Pve_cod = pve_cod;
                    compra.Ven_cod = ven_cod;
                    compra.Pve_datapagto = Convert.ToDateTime(registro["pve_datapagto"]);
                    compra.Pve_datavecto = Convert.ToDateTime(registro["pve_datavecto"]);
                    compra.Pve_valor = Convert.ToDouble(registro["pve_valor"]);
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
