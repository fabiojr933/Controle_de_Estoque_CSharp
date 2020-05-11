using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALCliente
    {
        private DALConexao conexao;

        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        //METEDO INSERIR NO BANCO DE DADOS
        public void Incluir(ModeloCliente modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO cliente (cli_nome, cli_cpfcnpj, cli_rgie, cli_rsocial, " +
                    "cli_tipo, cli_cep, cli_endereco, cli_bairro, cli_fone, cli_cel, cli_email, " +
                    "cli_endnumero, cli_cidade, cli_estado) VALUES (@cli_nome, @cli_cpfcnpj, @cli_rgie," +
                    "  @cli_rsocial, @cli_tipo, @cli_cep, @cli_endereco, @cli_bairro, @cli_fone, @cli_cel, " +
                    "@cli_email, @cli_endnumero, @cli_cidade, @cli_estado)";
                cmd.Parameters.AddWithValue("@cli_nome",modelo.Cli_nome);
                cmd.Parameters.AddWithValue("@cli_cpfcnpj",modelo.Cli_cpfcnpj);
                cmd.Parameters.AddWithValue("@cli_rgie",modelo.Cli_rgie);
                cmd.Parameters.AddWithValue("@cli_rsocial",modelo.Cli_rsocial);
                cmd.Parameters.AddWithValue("@cli_tipo",modelo.Cli_tipo);
                cmd.Parameters.AddWithValue("@cli_cep",modelo.Cli_cep);
                cmd.Parameters.AddWithValue("@cli_endereco",modelo.Cli_endereco);
                cmd.Parameters.AddWithValue("@cli_bairro",modelo.Cli_bairro);
                cmd.Parameters.AddWithValue("@cli_fone",modelo.Cli_fone);
                cmd.Parameters.AddWithValue("@cli_cel",modelo.Cli_cel);
                cmd.Parameters.AddWithValue("@cli_email",modelo.Cli_email);
                cmd.Parameters.AddWithValue("@cli_endnumero",modelo.Cli_endnumero);
                cmd.Parameters.AddWithValue("@cli_cidade",modelo.Cli_cidade);
                cmd.Parameters.AddWithValue("@cli_estado",modelo.Cli_estado);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ops! ocorreu algum erro " + ex.Message); ;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        //METEDO EDITAR CATEGORIA
        public void Alterar(ModeloCliente modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update cliente set cli_nome = @cli_nome, cli_cpfcnpj = @cli_cpfcnpj, cli_rgie = @cli_rgie," +
                    " cli_rsocial = @cli_rsocial, cli_tipo = @cli_tipo, cli_cep = @cli_cep, cli_endereco = @cli_endereco, " +
                    "cli_bairro = @cli_bairro, cli_fone = @cli_fone, cli_cel = @cli_cel, cli_email = @cli_email, " +
                    "cli_endnumero = @cli_endnumero, cli_cidade = @cli_cidade, cli_estado = @cli_estado where cli_cod = @cli_cod";
                cmd.Parameters.AddWithValue("@cli_nome", modelo.Cli_nome);
                cmd.Parameters.AddWithValue("@cli_cpfcnpj", modelo.Cli_cpfcnpj);
                cmd.Parameters.AddWithValue("@cli_rgie", modelo.Cli_rgie);
                cmd.Parameters.AddWithValue("@cli_rsocial", modelo.Cli_rsocial);
                cmd.Parameters.AddWithValue("@cli_tipo", modelo.Cli_tipo);
                cmd.Parameters.AddWithValue("@cli_cep", modelo.Cli_cep);
                cmd.Parameters.AddWithValue("@cli_endereco", modelo.Cli_endereco);
                cmd.Parameters.AddWithValue("@cli_bairro", modelo.Cli_bairro);
                cmd.Parameters.AddWithValue("@cli_fone", modelo.Cli_fone);
                cmd.Parameters.AddWithValue("@cli_cel", modelo.Cli_cel);
                cmd.Parameters.AddWithValue("@cli_email", modelo.Cli_email);
                cmd.Parameters.AddWithValue("@cli_endnumero", modelo.Cli_endnumero);
                cmd.Parameters.AddWithValue("@cli_cidade", modelo.Cli_cidade);
                cmd.Parameters.AddWithValue("@cli_estado", modelo.Cli_estado);
                cmd.Parameters.AddWithValue("@cli_cod", modelo.Cli_cod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ops! ocorreu algum erro " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        //METEDO EXCLUIR CATEGORIA
        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from cliente where cli_cod = @cli_cod";
                cmd.Parameters.AddWithValue("@cli_cod",codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ops correu algum erro " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        //LOCALIZAR CATEGORIA
        public DataTable Localizar(string valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from cliente where cli_nome like '%"+valor+"%'",conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Ops ocorreu algum erro " + ex.Message);
            }
        }

        //LOCALIZAR CATEGORIA por cpf
        public DataTable Localizarcpf(string valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from cliente where cli_cpfcnpj like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Ops ocorreu algum erro " + ex.Message);
            }
        }

        //CARREGAR TODAS AS CATEGORIAS
        public ModeloCliente carregaModeloClienteCod(int codigo)
        {
            try
            {
                ModeloCliente modelo = new ModeloCliente();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "select * from cliente where cli_cod = @cli_cod";
                cmd.Parameters.AddWithValue("@cli_cod",codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.Cli_cod = Convert.ToInt32(registro["cli_cod"]);
                    modelo.Cli_nome = Convert.ToString(registro["cli_nome"]);
                    modelo.Cli_cpfcnpj = Convert.ToString(registro["cli_cpfcnpj"]);
                    modelo.Cli_rgie = Convert.ToString(registro["cli_rgie"]);
                    modelo.Cli_rsocial = Convert.ToString(registro["cli_rsocial"]);
                    modelo.Cli_tipo = Convert.ToString(registro["cli_tipo"]);
                    modelo.Cli_cep = Convert.ToString(registro["cli_cep"]);
                    modelo.Cli_endereco = Convert.ToString(registro["cli_endereco"]);
                    modelo.Cli_bairro = Convert.ToString(registro["cli_bairro"]);
                    modelo.Cli_fone = Convert.ToString(registro["cli_fone"]);
                    modelo.Cli_cel = Convert.ToString(registro["cli_cel"]);
                    modelo.Cli_email = Convert.ToString(registro["cli_email"]);
                    modelo.Cli_endnumero = Convert.ToString(registro["cli_endnumero"]);
                    modelo.Cli_cidade = Convert.ToString(registro["cli_cidade"]);
                    modelo.Cli_estado = Convert.ToString(registro["cli_estado"]);
                    
                }
                conexao.Desconectar();
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("Ops ocorreu algum erro " + ex.Message);
            }
        }

        //CARREGAR TODAS AS CATEGORIAS COM PARAMENTRO CPFCNPJ
        public ModeloCliente carregaModeloClienteCpf(string cpfcnpj)
        {
            try
            {
                ModeloCliente modelo = new ModeloCliente();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from cliente where cli_cpfcnpj = @cli_cpfcnpj";
                cmd.Parameters.AddWithValue("@cli_cpfcnpj", cpfcnpj);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.Cli_cod = Convert.ToInt32(registro["cli_cod"]);
                    modelo.Cli_nome = Convert.ToString(registro["cli_nome"]);
                    modelo.Cli_cpfcnpj = Convert.ToString(registro["cli_nome"]);
                    modelo.Cli_rgie = Convert.ToString(registro["cli_rgie"]);
                    modelo.Cli_rsocial = Convert.ToString(registro["cli_rsocial"]);
                    modelo.Cli_tipo = Convert.ToString(registro["cli_tipo"]);
                    modelo.Cli_cep = Convert.ToString(registro["cli_cep"]);
                    modelo.Cli_endereco = Convert.ToString(registro["cli_endereco"]);
                    modelo.Cli_bairro = Convert.ToString(registro["cli_bairro"]);
                    modelo.Cli_fone = Convert.ToString(registro["cli_fone"]);
                    modelo.Cli_cel = Convert.ToString(registro["cli_cel"]);
                    modelo.Cli_email = Convert.ToString(registro["cli_email"]);
                    modelo.Cli_endnumero = Convert.ToString(registro["cli_endnumero"]);
                    modelo.Cli_cidade = Convert.ToString(registro["cli_cidade"]);
                    modelo.Cli_estado = Convert.ToString(registro["cli_estado"]);

                }
                conexao.Desconectar();
                return modelo;
            }
            catch (Exception ex)
            {
                throw new Exception("Ops ocorreu algum erro " + ex.Message);
            }
        }
    }
}
