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
    public class DALFornecedor
    {
        private DALConexao Conexao;
        
        public DALFornecedor(DALConexao cx)
        {
            this.Conexao = cx;
        }

        //METEDO INSERIR NO BANCO DE DADOS
        public void Incluir(ModeloFornecedor modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "insert into fornecedor(for_nome,for_rsocial,for_ie,for_cnpj,for_cep,for_endereco," +
                    "for_bairro,for_fone,for_cel,for_email,for_endnumero,for_cidade,for_estado) values(@for_nome,@for_rsocial," +
                    "@for_ie,@for_cnpj,@for_cep,@for_endereco,@for_bairro,@for_fone,@for_cel,@for_email,@for_endnumero,@for_cidade,@for_estado)";
                cmd.Parameters.AddWithValue("@for_nome",modelo.For_nome);
                cmd.Parameters.AddWithValue("@for_rsocial",modelo.For_rsocial);
                cmd.Parameters.AddWithValue("@for_ie",modelo.For_ie);
                cmd.Parameters.AddWithValue("@for_cnpj",modelo.For_cnpj);
                cmd.Parameters.AddWithValue("@for_cep",modelo.For_cep);
                cmd.Parameters.AddWithValue("@for_endereco",modelo.For_endereco);
                cmd.Parameters.AddWithValue("@for_bairro",modelo.For_bairro);
                cmd.Parameters.AddWithValue("@for_fone",modelo.For_fone);
                cmd.Parameters.AddWithValue("@for_cel",modelo.For_cel);
                cmd.Parameters.AddWithValue("@for_email",modelo.For_email);
                cmd.Parameters.AddWithValue("@for_endnumero",modelo.For_endnumero);
                cmd.Parameters.AddWithValue("@for_cidade",modelo.For_cidade);
                cmd.Parameters.AddWithValue("@for_estado",modelo.For_estado);
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
        //METEDO EDITAR CATEGORIA
        public void Alterar(ModeloFornecedor modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "update fornecedor set for_nome = @for_nome, for_rsocial = @for_rsocial, for_ie = @for_ie," +
                    " for_cnpj = @for_cnpj, for_cep = @for_cep, for_endereco = @for_endereco, for_bairro = @for_bairro, " +
                    "for_fone = @for_fone, for_cel = @for_cel, for_email = @for_email, for_endnumero = @for_endnumero, " +
                    "for_cidade = @for_cidade, for_estado = @for_estado where for_cod = @for_cod";
                cmd.Parameters.AddWithValue("@for_nome", modelo.For_nome);
                cmd.Parameters.AddWithValue("@for_rsocial", modelo.For_rsocial);
                cmd.Parameters.AddWithValue("@for_ie", modelo.For_ie);
                cmd.Parameters.AddWithValue("@for_cnpj", modelo.For_cnpj);
                cmd.Parameters.AddWithValue("@for_cep", modelo.For_cep);
                cmd.Parameters.AddWithValue("@for_endereco", modelo.For_endereco);
                cmd.Parameters.AddWithValue("@for_bairro", modelo.For_bairro);
                cmd.Parameters.AddWithValue("@for_fone", modelo.For_fone);
                cmd.Parameters.AddWithValue("@for_cel", modelo.For_cel);
                cmd.Parameters.AddWithValue("@for_email", modelo.For_email);
                cmd.Parameters.AddWithValue("@for_endnumero", modelo.For_endnumero);
                cmd.Parameters.AddWithValue("@for_cidade", modelo.For_cidade);
                cmd.Parameters.AddWithValue("@for_estado", modelo.For_estado);
                cmd.Parameters.AddWithValue("@for_cod", modelo.For_cod);
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

        //METEDO EXCLUIR CATEGORIA
        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "delete from fornecedor where for_cod = @for_cod";
                cmd.Parameters.AddWithValue("@for_cod",codigo);
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
        public DataTable Localizar(string valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select for_cod, for_nome, for_cnpj, for_cel from fornecedor " +
                    "where for_nome like '%"+valor+"%'",Conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CARREGAR TODAS AS CATEGORIAS
        public ModeloFornecedor carregaModeloClienteCod(int codigo)
        {
            try
            {
                ModeloFornecedor fornecedor = new ModeloFornecedor();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandText = "select * from fornecedor where for_cod = @for_cod";
                cmd.Parameters.AddWithValue("@for_cod", codigo);
                Conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();               
                if (registro.HasRows)
                {
                    registro.Read();
                    fornecedor.For_cod = Convert.ToInt32(registro["for_cod"]);
                    fornecedor.For_nome = Convert.ToString(registro["for_nome"]);
                    fornecedor.For_rsocial = Convert.ToString(registro["for_rsocial"]);
                    fornecedor.For_ie = Convert.ToString(registro["for_ie"]);
                    fornecedor.For_cnpj= Convert.ToString(registro["for_cnpj"]); 
                    fornecedor.For_cep = Convert.ToString(registro["for_cep"]);
                    fornecedor.For_endereco = Convert.ToString(registro["for_endereco"]);
                    fornecedor.For_bairro = Convert.ToString(registro["for_bairro"]);
                    fornecedor.For_fone = Convert.ToString(registro["for_fone"]);
                    fornecedor.For_cel = Convert.ToString(registro["for_cel"]);
                    fornecedor.For_email = Convert.ToString(registro["for_email"]);
                    fornecedor.For_endnumero = Convert.ToString(registro["for_endnumero"]);
                    fornecedor.For_cidade = Convert.ToString(registro["for_cidade"]);
                    fornecedor.For_estado = Convert.ToString(registro["for_estado"]);
                }
                return fornecedor;
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
