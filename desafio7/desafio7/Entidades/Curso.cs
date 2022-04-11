using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio7
{
    public class Curso
    {
        public string nome { get; set; }
        public int id { get; set; }

        public Curso(string nome, int id)
        {
            this.nome = nome;
            this.id = id;
        }
    }
}
