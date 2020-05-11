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
    public class DALCategoria
    {
        private DALConexao conexao;

        public DALCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)  //METEDO INSERIR NO BANCO DE DADOS
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO CATEGORIA(cat_nome) values(@cat_nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@cat_nome", modelo.Cat_nome);
            conexao.Conectar();
            modelo.Cat_cod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCategoria modelo)  //METEDO EDITAR CATEGORIA 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update CATEGORIA set cat_nome = @cat_nome where cat_cod = @cat_cod";
            cmd.Parameters.AddWithValue("@cat_cod", modelo.Cat_cod);
            cmd.Parameters.AddWithValue("@cat_nome", modelo.Cat_nome);         
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)   //METEDO EXCLUIR CATEGORIA
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from categoria where cat_cod = @cat_cod";
            cmd.Parameters.AddWithValue("@cat_cod", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(string valor)  //LOCALIZAR CATEGORIA
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from categoria where cat_nome like '%" +
                valor + "%' order by cat_cod asc", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCategoria carregaModeloCategoria(int codigo)  //CARREGAR TODAS AS CATEGORIAS
        {
            ModeloCategoria modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from categoria where cat_cod = @cat_codigo";
            cmd.Parameters.AddWithValue("@cat_codigo",codigo.ToString());
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Cat_cod = Convert.ToInt32(registro["cat_cod"]);
                modelo.Cat_nome = Convert.ToString(registro["cat_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
