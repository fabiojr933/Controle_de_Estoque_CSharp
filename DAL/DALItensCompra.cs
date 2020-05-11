using Modelo;
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
    public class DALItensCompra
    {
        private DALConexao Conexao;

        public DALItensCompra(DALConexao cx)
        {
            this.Conexao = cx;
        }
        //METEDO INSERIR
        public void Inserir(ModeloItensCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "insert into itenscompra(itc_cod,itc_qtde,itc_valor,com_cod,pro_cod)" +
                    "values(@itc_cod, @itc_qtde, @itc_valor, @com_cod, @pro_cod)";
                cmd.Parameters.AddWithValue("@itc_cod", modelo.Itc_cod);
                cmd.Parameters.AddWithValue("@itc_qtde", modelo.Itc_qtde);
                cmd.Parameters.AddWithValue("@itc_valor", modelo.Itc_valor);
                cmd.Parameters.AddWithValue("@com_cod", modelo.Com_cod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.Pro_cod);
                Conexao.Conectar();
                cmd.ExecuteNonQuery();
              //  modelo.Com_cod = Convert.ToInt32(cmd.ExecuteScalar());
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
        public void Alterar(ModeloItensCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "update itenscompra set itc_qtde = @itc_qtde,itc_valor = @itc_valor " +
                    "where itc_cod = @itc_cod and com.cod = @com.cod and pro.cod = @pro.cod";               
                cmd.Parameters.AddWithValue("@itc_qtde", modelo.Itc_qtde);
                cmd.Parameters.AddWithValue("@itc_valor", modelo.Itc_valor);
                cmd.Parameters.AddWithValue("@itc_cod", modelo.Itc_cod);
                cmd.Parameters.AddWithValue("@com.cod", modelo.Com_cod);
                cmd.Parameters.AddWithValue("@pro.cod", modelo.Pro_cod);
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
        public void Excluir(ModeloItensCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "delete from itenscompra " +
                    "where itc_cod = @itc_cod and com.cod = @com.cod and pro.cod = @pro.cod";
                cmd.Parameters.AddWithValue("@itc_cod", modelo.Itc_cod);
                cmd.Parameters.AddWithValue("@com.cod", modelo.Com_cod);
                cmd.Parameters.AddWithValue("@pro.cod", modelo.Pro_cod);
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

        //METEDO LOCALIZAR
        public DataTable Localizar(int codigo)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select i.com_cod AS Codigo, p.pro_cod as Cod_Produto, p.pro_descricao as Descricao, I.itc_qtde AS Qtd, i.itc_valor as Valor " +
                    "from itenscompra i inner join produto p on i.pro_cod = p.pro_cod where com_cod = "+codigo.ToString(),Conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //METEDO CARREGA MODELO
        public ModeloItensCompra CarregaModeloItensCompra(int Itc_cod, int Com_cod, int Pro_cod)
        {
            try
            {
                ModeloItensCompra modeloItens = new ModeloItensCompra();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "select * from itenscompra where itc_cod = @itc_cod and com.cod = @com.cod and pro.cod = @pro.cod";
                cmd.Parameters.AddWithValue("@itc_cod", Itc_cod);
                cmd.Parameters.AddWithValue("@com.cod", Com_cod);
                cmd.Parameters.AddWithValue("@pro.cod", Pro_cod);
                Conexao.Conectar();
                SqlDataReader da = cmd.ExecuteReader();

                if (da.HasRows)
                {
                    da.Read();
                    modeloItens.Itc_cod = Itc_cod;
                    modeloItens.Com_cod = Com_cod;
                    modeloItens.Pro_cod = Pro_cod;
                    modeloItens.Itc_qtde = Convert.ToInt32(da["itc_qtde"]);
                    modeloItens.Itc_valor = Convert.ToDouble(da["itc_valor"]);
                }
                return modeloItens;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
