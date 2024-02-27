using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelUser
    {
        private int id;
        private string nome;
        private string idade;
        private string sexo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Idade { get => idade; set => idade = value; }
        public string Sexo { get => sexo; set => sexo = value; }
    }
}
