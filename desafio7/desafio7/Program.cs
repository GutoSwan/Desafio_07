using System;

namespace desafio7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("digite o nome do aluno: ");
            var nomeAluno = Console.ReadLine();

            Console.WriteLine("digite a nota do aluno");
            var notaAluno = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a idade do aluno: ");
            var idadeAluno = int.Parse (Console.ReadLine());

            var aluno = new Aluno(nomeAluno, idadeAluno, notaAluno);

            var curso = new Curso(nomeAluno, 10);

            var status = new Status(2,nomeAluno,DateTime.Now, 5);

            var Daocurso = new DaoCurso();

            var Daostatus = new DaoStatus();

            var DaoAluno = new DaoAluno();

            DaoAluno.salvar(aluno, 95);

            Daocurso.salvar(curso,5);

            Daostatus.salvar(status,1);
        }
    }
}