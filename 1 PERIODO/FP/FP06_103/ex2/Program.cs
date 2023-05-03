using System;

namespace ex2
{
    class Program
    {
        const int tamVet = 10;

        static void Main(string[] args)
        {
            int[] vetor1 = new int[tamVet];
            int[] vetor2 = new int[tamVet];
            int[] result = new int[tamVet];

            for(int i = 0; i < tamVet; i++)
            {
                Console.Write("VETOR 1: numero {0} de {1}: ", i+1, tamVet);
                vetor1[i] = Int32.Parse(Console.ReadLine());

                Console.Write("VETOR 2: numero {0} de {1}: ", i+1, tamVet);
                vetor2[i] = Int32.Parse(Console.ReadLine());

                result[i] = vetor1[i] + vetor2[i];
            }

            Console.Write("Soma dos vetores 1 e 2: ");
            for(int i = 0; i<tamVet; i++)
            {
                if(i==tamVet-1)
                {
                    Console.Write(result[i]);
                }
                else
                {
                    Console.Write(result[i] + ",");    
                }
                
            }
        }
    }
}