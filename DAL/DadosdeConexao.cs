using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace DAL
{
    public class DadosdeConexao
    {
        public static string StringConexao 
        {
            get
            {
                return "SERVER=localhost; DATABASE=crud; User Id=root; Password=klb@@13%;";
            }
        }
    }
}
