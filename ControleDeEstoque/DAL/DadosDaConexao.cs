using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = @"DESKTOP-LSD8KOT\SQLEXPRESS";
        public static String banco = "ControleDeEstoque";
        public static String usuario = "sa";
        public static String senha = "hiro";
        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=" + servidor + "; Initial Catalog=" + banco + "; User=" + usuario + ";Password=" + senha;
            }
        }
    }
}
