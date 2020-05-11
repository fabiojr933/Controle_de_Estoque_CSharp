using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static string servidor = @"10.1.1.29\SQLEXPRESS";                                // @"DESKTOP-3EPT6BV\SQLEXPRESS";
        public static string banco = "ControleDeEstoque";
        public static string usuario = "fabio";
        public static string senha = "12345678";

        public static String StringDeConexao
        {

            get
            {
               //   return @"Data Source=10.1.1.29\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=ControleDeEstoque;User ID=fabio;Password=12345678;";
                    return @"Data Source="+servidor+";Initial Catalog="+banco+";User ID="+usuario+";Password="+senha;
            }
        }
    }
}
