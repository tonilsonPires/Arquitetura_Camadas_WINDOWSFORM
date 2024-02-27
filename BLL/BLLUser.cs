using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLUser
    {
        private DALConexao conexao;

        public BLLUser(DALConexao conexao)
        {
            this.conexao = conexao;
        }

        public bool adicionar(ModelUser model) 
        { 
            if (model.Nome == "" || model.Sexo == "" || model.Idade == "") 
            {
                throw new Exception("Todos campos devem ser Obrigatorios");
            }
            else
            {
                DALUser dal = new DALUser(this.conexao);
                bool result = dal.adicionar(model);

                if(result == false) 
                { 
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool actualizar(ModelUser model)
        {
            if (model.Nome == "" || model.Sexo == "" || model.Idade == "")
            {
                throw new Exception("Todos campos devem ser Obrigatorios");
            }
            else
            {
                DALUser dal = new DALUser(this.conexao);
                bool result = dal.actualizar(model);

                if (result == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public void delete(int codigo) 
        {
            DALUser dal = new DALUser(this.conexao);
            dal.delete(codigo);
        }

        public DataTable listar() 
        {
            DALUser dal = new DALUser(this.conexao);
            return dal.listarDados();

        }


    }
}
