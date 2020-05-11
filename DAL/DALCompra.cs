using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALCompra
    {
        private DALConexao Conexao;

        public DALCompra(DALConexao cx)
        {
            this.Conexao = cx;
        }

        //METEDO INSIRIR
        public void Incluir(ModeloCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "Insert into compra (com_data, com_nfiscal, com_total, com_nparcelas, com_status, for_cod, tpa_cod) " +
                    "values(@com_data, @com_nfiscal, @com_total, @com_nparcelas, @com_status, @for_cod, @tpa_cod); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@com_data", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@com_data"].Value = modelo.Com_data;
                cmd.Parameters.AddWithValue("@com_nfiscal",modelo.Com_nfiscal);
                cmd.Parameters.AddWithValue("@com_total",modelo.Com_total);
                cmd.Parameters.AddWithValue("@com_nparcelas",modelo.Com_nparcelas);
                cmd.Parameters.AddWithValue("@com_status",modelo.Com_status);
                cmd.Parameters.AddWithValue("@for_cod",modelo.For_cod);
                cmd.Parameters.AddWithValue("@tpa_cod",modelo.Tpa_cod);
                Conexao.Conectar();
                modelo.Com_cod = Convert.ToInt32(cmd.ExecuteScalar());
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
        public void Alterar(ModeloCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "update compra set com_data = @com_data, com_nfiscal = @com_nfiscal, " +
                    "com_total = @com_total, com_nparcelas = @com_nparcelas, com_status = @com_status, for_cod = @for_cod," +
                    " tpa_cod = tpa_cod where com_cod = @com_cod";
                cmd.Parameters.AddWithValue("@com_data", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@com_data"].Value = modelo.Com_data;
                cmd.Parameters.AddWithValue("@com_nfiscal", modelo.Com_nfiscal);
                cmd.Parameters.AddWithValue("@com_total", modelo.Com_total);
                cmd.Parameters.AddWithValue("@com_nparcelas", modelo.Com_nparcelas);
                cmd.Parameters.AddWithValue("@com_status", modelo.Com_status);
                cmd.Parameters.AddWithValue(" @for_cod", modelo.For_cod);
                cmd.Parameters.AddWithValue("@tpa_cod", modelo.Tpa_cod);
                cmd.Parameters.AddWithValue("@com_cod", modelo.Com_cod);
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
        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "delete from compra where com_cod = @com_cod";
                cmd.Parameters.AddWithValue("@com_cod",codigo);
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

        public DataTable LocalizarPorFornecedor(int Codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select g.for_cod, f.for_nome, g.com_data, g.com_nfiscal, " +
                    "g.com_total,g.com_status, g.com_nparcelas, g.tpa_cod from fornecedor f join compra g on g.for_cod = f.for_cod " +
                    "where g.for_cod ="+Codigo.ToString(),Conexao.ObjetoConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable LocalizarPorNome(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_total, " +
                    "c.com_status,c.for_cod, f.for_nome, c.tpa_cod from compra c" +
                    " inner join fornecedor f on c.for_cod = f.for_cod where f.for_nome like '%"+nome+"%'",Conexao.ObjetoConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable LocalizarPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "select c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_total, " +
                    "c.com_status,c.for_cod, f.for_nome, c.tpa_cod from compra c" +
                    " inner join fornecedor f on c.for_cod = f.for_cod where c.com_data between @dataIncial and @dataFinal";
                cmd.Parameters.AddWithValue("@dataIncial",System.Data.SqlDbType.DateTime);
                cmd.Parameters["@dataIncial"].Value = dataInicial;
                cmd.Parameters.AddWithValue("@dataFinal", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@dataFinal"].Value = dataFinal;
                //Conexao.Conectar();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

      //  CARREGA MODELO COMPRA
        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            try
            {
                ModeloCompra compra = new ModeloCompra();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "select * from compra where com_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                Conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    compra.Com_cod = Convert.ToInt32(registro["com_cod"]);
                    compra.Com_data = Convert.ToDateTime(registro["com_data"]);
                    compra.Com_nfiscal = Convert.ToInt32(registro["com_nfiscal"]);
                    compra.Com_total = Convert.ToDouble(registro["com_total"]);
                    compra.Com_nparcelas = Convert.ToInt32(registro["com_nparcelas"]);
                    compra.Com_status = Convert.ToString(registro["com_status"]);
                    compra.For_cod = Convert.ToInt32(registro["for_cod"]);
                    compra.Tpa_cod = Convert.ToInt32(registro["tpa_cod"]);                    
                }
                return compra;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); ;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }


        public DataTable LocalizarPorParcela()
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select distinct c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_total, " +
                    "c.com_status,c.for_cod, f.for_nome, c.tpa_cod from compra c" +
                    " inner join fornecedor f on c.for_cod = f.for_cod JOIN parcelascompra p on c.com_cod = p.com_cod where p.pco_datapagto IS NULL", Conexao.ObjetoConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
