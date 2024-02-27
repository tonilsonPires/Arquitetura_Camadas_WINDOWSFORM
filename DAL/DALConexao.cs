using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALConexao
    {
        private string _stringConexao;
        private MySqlConnection _conexao;

        public DALConexao(string dadosConexao)
        {
            this._conexao = new MySqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public MySqlConnection ObjectoConexao 
        { 
            get { return this._conexao; }
            set { this._conexao = value;}
        }

        public string StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public void Conectar() 
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
