using System;

namespace ex4
{
    class Program
    {
        const int tamVet = 10;

        static void Main(string[] args)
        {
            int[] idades = new int[tamVet];
            double media = 0;
            
            for(int i = 0; i < tamVet; i++)
            {
                Console.Write("Insira a idade {0} de {1}: ", i+1, tamVet);
                idades[i] = Int32.Parse(Console.ReadLine());

                media += idades[i];
            }
            
            Console.WriteLine("{0} idades maiores que a média.", CalculaIdadeMaiorMedia(idades,media));
        
        }

        static int CalculaIdadeMaiorMedia(int[] idades, double media)
        {
            int contador = 0;
            media = media / tamVet;

            for(int i = 0; i < tamVet; i++)
            {
                if(idades[i] > media)
                {
                    contador++; 
                }
            }

            return contador;
        }
    }
}
