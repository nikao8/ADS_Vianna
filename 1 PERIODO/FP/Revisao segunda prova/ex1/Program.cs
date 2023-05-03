using System;

namespace ex1
{
    class Program
    {
        const int tamVet = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os valores do vetor: ");
            int[] vet = new int[5];

            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Valor {0} -> ", i);
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("O valor da soma do vetor é de: {0}", SomaVet(vet));
        }

        static double SomaVet(int[] vet)
        {
            double soma = 0;
            for(int i = 0; i < vet.Length; i++)
            {
                soma += vet[i];
            }

            return soma;
        }
    }
}
