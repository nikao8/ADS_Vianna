using System;

namespace ex6
{
    class Program
    {
        const int tamVet = 20;
        static void Main(string[] args)
        {
            int[] valores = new int[tamVet];
            
            for(int j=0; j<tamVet; j++)
            {
                Console.Write("Insira o valor no indice {0}: ", j);
                valores[j] = Int32.Parse(Console.ReadLine());
            }

            CalculaMenorVetor(valores);
        }

        static void CalculaMenorVetor(int[] valores)
        {
            int menor = valores[0], aux = 0;
            for(int i = 0; i < tamVet; i++)
            {
                if(valores[i] < menor)
                {
                    menor = valores[i];
                    aux = i;
                }
            }

            Console.WriteLine("O menor valor inserido é {0} no indice {1}", menor, aux);
        }
    }
}
