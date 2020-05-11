using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data.SqlClient;
using System.Data;
using Ferramentas;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLLCliente
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }
        //METEDO INSERIR NO BANCO DE DADOS
        public void Incluir(ModeloCliente modelo)
        {
            if(modelo.Cli_nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatorio");
            }

            if (modelo.Cli_cpfcnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF OU CNPJ do cliente é obrigatorio");
            }

            //if (modelo.Cli_cpfcnpj == "F")
            //{
            //    if (Validacao.IsCpf(modelo.Cli_cpfcnpj) == false)
            //    {
            //        throw new Exception(" O CPF ou CNPJ do cliente é Invalido ");
            //    }
            //}
            //else
            //{
            //    if (Validacao.IsCnpj(modelo.Cli_cpfcnpj) == false)
            //    {
            //        throw new Exception(" O CPF ou CNPJ do cliente é Invalido");
            //    }
            //}  
            
             if (modelo.Cli_fone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatorio");
            }

            if(modelo.Cli_rgie.Trim().Length == 0)
            {
                throw new Exception("O RG do cliente é obrigatorio");
            }

            //string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
            //                    + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
            //                    + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            //Regex re = new Regex(strRegex);
            //if (!re.IsMatch(modelo.Cli_email))
            //{
            //    throw new Exception("Digite um email válido.");
            //}
            
            //cli_tipo = 0 => fisica
            //cli_tipo = 1 => juridica
            DALCliente cliente = new DALCliente(conexao);
            cliente.Incluir(modelo);
        }

        //METEDO ALTERAR
        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.Cli_nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatorio");
            }
            if (modelo.Cli_cpfcnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF OU CNPJ do cliente é obrigatorio");
            }
            if (modelo.Cli_fone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatorio");
            }
            if (modelo.Cli_rgie.Trim().Length == 0)
            {
                throw new Exception("O RG do cliente é obrigatorio");
            }
            //cli_tipo = 0 => fisica
            //cli_tipo = 1 => juridica
            DALCliente cliente = new DALCliente(conexao);
            cliente.Alterar(modelo);
        }

        //METEDO EXCLUIR CATEGORIA
        public void Excluir(int codigo)
        {
            DALCliente cliente = new DALCliente(conexao);
            cliente.Excluir(codigo);
        }

        //LOCALIZAR CATEGORIA
        public DataTable Localizar(string valor)
        {           
            DALCliente cliente = new DALCliente(conexao);
            return cliente.Localizar(valor);
        }

        //CARREGAR TODAS AS CATEGORIAS
        public ModeloCliente carregaModeloClienteCod(int codigo)
        {
            DALCliente cliente = new DALCliente(conexao);
            return cliente.carregaModeloClienteCod(codigo);
        }
        //CARREGAR TODAS AS CATEGORIAS
        public ModeloCliente carregaModeloClienteCpf(string cpfcnpj)
        {
            DALCliente cliente = new DALCliente(conexao);
            return cliente.carregaModeloClienteCpf(cpfcnpj);
        }

        //LOCALIZAR CATEGORIA por cpf
        public DataTable Localizarcpf(string valor)
        {
            DALCliente cliente = new DALCliente(conexao);
            return cliente.Localizarcpf(valor);
        }
    }
}
