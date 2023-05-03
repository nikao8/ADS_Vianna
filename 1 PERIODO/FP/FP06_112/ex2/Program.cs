using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            LeVetor(vetor);
        }

        static void LeVetor(int[] vetor)
        {
            for(int i = 0;i < vetor.Length; i++)
            {
                Console.Write("Valor {0} de {1}: ",i,vetor.Length-1);
                vetor[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Valores armazenados nos indices pares: ");
            for(int i = 0; i < vetor.Length; i++)
            {
                if(i%2==0)
                {
                    Console.Write(vetor[i] + " ");
                }
            }
        }
    }
}
