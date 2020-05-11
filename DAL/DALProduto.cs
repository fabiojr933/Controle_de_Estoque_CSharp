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
    public class DALProduto
    {
        DALConexao conexao;
        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        //METEDO INCLUIR
        public void Incluir(ModeloProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into produto (pro_nome, pro_descricao, pro_foto, pro_valorpago, pro_valorvenda, pro_qtde, umed_cod, cat_cod, scat_cod)" +
                    "values(@pro_nome, @pro_descricao, @pro_foto, @pro_valorpago, @pro_valorvenda, @pro_qtde, @umed_cod, @cat_cod, @scat_cod)";
                cmd.Parameters.AddWithValue("@pro_nome", modelo.Pro_nome);
                cmd.Parameters.AddWithValue("@pro_descricao",modelo.Pro_descricao);
                cmd.Parameters.Add("@pro_foto",System.Data.SqlDbType.Image);
                if (modelo.Pro_foto == null)
                {
                    cmd.Parameters["@pro_foto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@pro_foto"].Value = modelo.Pro_foto;
                }
                cmd.Parameters.AddWithValue("@pro_valorpago",modelo.Pro_valorpago);
                cmd.Parameters.AddWithValue("@pro_valorvenda",modelo.Pro_valorvenda);
                cmd.Parameters.AddWithValue("@pro_qtde",modelo.Pro_qtde);
                cmd.Parameters.AddWithValue("@umed_cod",modelo.Umed_cod);
                cmd.Parameters.AddWithValue("@cat_cod",modelo.Cat_cod);
                cmd.Parameters.AddWithValue("@scat_cod",modelo.Scat_cod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ops ocorreu algum erro ao salvar " + ex.Message);
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
                cmd.CommandText = "delete from produto where pro_cod = @pro_cod";
                cmd.Parameters.AddWithValue("@pro_cod",codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ops ocorreu algum erro ao excluir " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }  
        }


        //METEDO ALTERAR
        public void Alterar(ModeloProduto modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update produto set pro_nome = @pro_nome, pro_descricao = @pro_descricao, pro_foto =  @pro_foto," +
                    " pro_valorpago =  @pro_valorpago, pro_valorvenda = @pro_valorvenda, pro_qtde = @pro_qtde, umed_cod = @umed_cod," +
                    " cat_cod = @cat_cod, scat_cod = @scat_cod where pro_cod = @pro_cod";                    
                cmd.Parameters.AddWithValue("@pro_nome", modelo.Pro_nome);
                cmd.Parameters.AddWithValue("@pro_descricao", modelo.Pro_descricao);
                cmd.Parameters.Add("@pro_foto", System.Data.SqlDbType.Image);
                if (modelo.Pro_foto == null)
                {
                    cmd.Parameters["@pro_foto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@pro_foto"].Value = modelo.Pro_foto;
                }
                cmd.Parameters.AddWithValue("@pro_valorpago", modelo.Pro_valorpago);
                cmd.Parameters.AddWithValue("@pro_valorvenda", modelo.Pro_valorvenda);
                cmd.Parameters.AddWithValue("@pro_qtde", modelo.Pro_qtde);
                cmd.Parameters.AddWithValue("@umed_cod", modelo.Umed_cod);
                cmd.Parameters.AddWithValue("@cat_cod", modelo.Cat_cod);
                cmd.Parameters.AddWithValue("@scat_cod", modelo.Scat_cod);
                cmd.Parameters.AddWithValue("@pro_cod", modelo.Pro_cod);                
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ops ocorreu algum erro ao salvar " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        //METEDO LOCALIZAR
        public DataTable Localizar(string valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from produto where pro_nome like '%" + valor + "%'order by pro_cod asc", DadosDaConexao.StringDeConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu algum erro ao localizar " + ex.Message);
            }
        }

        //METEDO CARREGAR PRODUTOS
        public ModeloProduto carregarModeloProdutos(int codigo)
        {
            try
            {
                ModeloProduto produto = new ModeloProduto();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from produto where pro_cod = @pro_cod";
                cmd.Parameters.AddWithValue("pro_cod", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    produto.Pro_cod = Convert.ToInt32(registro["pro_cod"]);
                    produto.Pro_nome = Convert.ToString(registro["pro_nome"]);
                    produto.Pro_descricao = Convert.ToString(registro["pro_descricao"]);
                    produto.Pro_foto = (byte[])registro["pro_foto"];
                    produto.Pro_valorpago = Convert.ToInt32(registro["pro_valorpago"]);
                    produto.Pro_valorvenda = Convert.ToInt32(registro["pro_valorvenda"]);
                    produto.Pro_qtde = Convert.ToInt32(registro["pro_qtde"]);
                    produto.Umed_cod = Convert.ToInt32(registro["umed_cod"]);
                    produto.Cat_cod = Convert.ToInt32(registro["cat_cod"]);
                    produto.Scat_cod = Convert.ToInt32(registro["scat_cod"]);
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ops ocorreu algum erro " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
