using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BBL

{
    public class BLLTipoPagamento
    {
        private DALConexao conexao;

        public BLLTipoPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        //METEDO SALVAR
        public void Incluir(ModeloTipoPagamento modelo)
        {
            if(modelo.Tpa_nome.Trim().Length == 0)
            {
                throw new Exception("Nome do tipo de pagamento é OBRIGADORIO");
            }
            DALTipoPagamento tipoPagamento = new DALTipoPagamento(conexao);
            tipoPagamento.Incluir(modelo);
        }

        //METEDO PARA ALTERAR
        public void Alterar(ModeloTipoPagamento modelo)
        {
            if (modelo.Tpa_nome.Trim().Length == 0)
            {
                throw new Exception("Selecione uma condição de pagamento");
            }
            modelo.Tpa_cod = modelo.Tpa_cod;
            DALTipoPagamento tipoPagamento = new DALTipoPagamento(conexao);
            tipoPagamento.Alterar(modelo);
        }

        //METEDO EXCLUIR
        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("selecione um tipo de pagamento");
            }
            DALTipoPagamento tipoPagamento = new DALTipoPagamento(conexao);
            tipoPagamento.Excluir(codigo);
        }

        //LOCALIZAR 
        public DataTable Localizar(string valor)
        {
            DALTipoPagamento tipoPagamento = new DALTipoPagamento(conexao);
            return tipoPagamento.Localizar(valor);
        }

        //CARREGAR TODAS AS UND MEDIDAS
        public ModeloTipoPagamento carregarTipoPagamentos(int codigo)
        {
            DALTipoPagamento tipoPagamento = new DALTipoPagamento(conexao);
            return tipoPagamento.carregarTipoPagamento(codigo);
        }
    }
}
