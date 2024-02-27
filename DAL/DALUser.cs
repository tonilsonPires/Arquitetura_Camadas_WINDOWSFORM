using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MODEL;

namespace DAL
{
    public class DALUser
    {
        private DALConexao conexao;

        public DALUser(DALConexao conexao) 
        {
            this.conexao = conexao;
        }

        public bool adicionar(ModelUser model)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.conexao.ObjectoConexao;

            cmd.CommandText = "INSERT user (nome,idade,sexo) VALUES(@nome,@idade,@sexo) ";
            cmd.Parameters.AddWithValue("@nome", model.Nome);
            cmd.Parameters.AddWithValue("@idade", model.Idade);
            cmd.Parameters.AddWithValue("@sexo", model.Sexo);

            this.conexao.Conectar();

            int result = cmd.ExecuteNonQuery();

            this.conexao.Desconectar();
            if (result <=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool actualizar(ModelUser model)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.conexao.ObjectoConexao;

            cmd.CommandText = "UPDATE user SET nome=@nome,idade=@idade,sexo=@sexo WHERE id_user = @id ";
            cmd.Parameters.AddWithValue("@nome", model.Nome);
            cmd.Parameters.AddWithValue("@idade", model.Idade);
            cmd.Parameters.AddWithValue("@sexo", model.Sexo);
            cmd.Parameters.AddWithValue("@Id", model.Id);

            this.conexao.Conectar();

            int result = cmd.ExecuteNonQuery();

            this.conexao.Desconectar();
            if (result <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void delete(int codigo)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.conexao.ObjectoConexao;

            cmd.CommandText = "DELETE FROM user WHERE id_user = @id";
            cmd.Parameters.AddWithValue("@id", codigo);
            
            this.conexao.Conectar();

            cmd.ExecuteNonQuery();

            this.conexao.Desconectar();
           
        }

        public DataTable listarDados() 
        {
            DataTable dados = new DataTable();
            MySqlDataAdapter rd = new MySqlDataAdapter("SELECT * FROM user", this.conexao.StringConexao);
            rd.Fill(dados);
            return dados;
        }
    }
}
