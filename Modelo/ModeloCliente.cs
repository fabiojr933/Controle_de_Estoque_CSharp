using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloCliente
    {
        private int cli_cod;
        private string cli_nome;
        private string cli_cpfcnpj;
        private string cli_rgie;
        private string cli_rsocial;
        private string cli_tipo;
        private string cli_cep;
        private string cli_endereco;
        private string cli_bairro;
        private string cli_fone;
        private string cli_cel;
        private string cli_email;
        private string cli_endnumero;
        private string cli_cidade;
        private string cli_estado;

        public int Cli_cod { get => cli_cod; set => cli_cod = value; }
        public string Cli_nome { get => cli_nome; set => cli_nome = value; }
        public string Cli_cpfcnpj { get => cli_cpfcnpj; set => cli_cpfcnpj = value; }
        public string Cli_rgie { get => cli_rgie; set => cli_rgie = value; }
        public string Cli_rsocial { get => cli_rsocial; set => cli_rsocial = value; } 
        public string Cli_cep { get => cli_cep; set => cli_cep = value; }
        public string Cli_endereco { get => cli_endereco; set => cli_endereco = value; }
        public string Cli_bairro { get => cli_bairro; set => cli_bairro = value; }
        public string Cli_fone { get => cli_fone; set => cli_fone = value; }
        public string Cli_cel { get => cli_cel; set => cli_cel = value; }
        public string Cli_email { get => cli_email; set => cli_email = value; }
        public string Cli_endnumero { get => cli_endnumero; set => cli_endnumero = value; }
        public string Cli_cidade { get => cli_cidade; set => cli_cidade = value; }
        public string Cli_estado { get => cli_estado; set => cli_estado = value; }
        public string Cli_tipo { get => cli_tipo; set => cli_tipo = value; }
    }
}
