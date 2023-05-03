using System;

namespace ex6
{
    class Program
    {
        const int tamVet = 5;
        static void Main(string[] args)
        {
            double[] notas = new double[tamVet];
            double soma = 0;

            for(int i = 0; i < notas.Length; i++)
            {
                Console.Write("Nota do aluno {0}: ", i+1);
                notas[i] = Double.Parse(Console.ReadLine());

                soma += notas[i];
            }

            Console.WriteLine("\nMedia da turma: {0}\nAlunos aprovados: {1}\nAlunos reprovados: {2}", CalculaMedia(notas.Length, soma), CalculaAprovados(notas), CalculaReprovados(notas) );
        }

        static double CalculaMedia(int qtdAlunos, double soma)
        {
            return soma / qtdAlunos;
        }

        static int CalculaReprovados(double[] notas)
        {
            int reprovados = 0;
            for(int i = 0; i < notas.Length; i++)
            {
                if(notas[i] < 60)
                {
                    reprovados++;
                }
            }

            return reprovados;
        }

        static int CalculaAprovados(double[] notas)
        {
            int aprovados = 0;
            for(int i = 0; i < notas.Length; i++)
            {
                if(notas[i] >= 60)
                {
                    aprovados++;
                }
            }

            return aprovados;













            for(int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + ",");

                if(i == vetor.Length - 1)
                {
                    Console.Write(vetor[i]);
                    break;
                }
            }
        }
    }
}


