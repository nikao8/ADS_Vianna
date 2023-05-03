using System;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno(123, "José da Silva");
            Aluno b = new Aluno();

            a.Nome = "José";
            a.Matricula = 123001;

            b.Nome = "Ana";
            b.Matricula = 123002;

            Console.WriteLine("Alunos:");

            Console.WriteLine(a.Nome);
            Console.WriteLine(b.Nome);


            // Vetor de objetos:

            Aluno listaAlunos = new Aluno[2];

            listaAlunos[0] = new Aluno();
            listaAlunos[0].Nome("Gustavo");
            listaAlunos[0].Matricula(4004);

            listaAlunos[1] = new Aluno();
            listaAlunos[1].Nome("Sandro")
            listaAlunos[1].Matricula(4454);
        }
    }
}
