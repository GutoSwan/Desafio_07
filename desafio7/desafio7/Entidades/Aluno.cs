using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio7
{
    public class Aluno
    {


        public string nome;
        public int idade;
        public double nota;

        public Aluno(string nome, int idade, double nota)
        {

            this.nome = nome;
            this.idade = idade;
            this.nota = nota;
        }
        public Aluno CriarAluno(Aluno aluno)
        {
            return new Aluno(aluno.nome, aluno.idade, aluno.nota);
        }

    }

}

