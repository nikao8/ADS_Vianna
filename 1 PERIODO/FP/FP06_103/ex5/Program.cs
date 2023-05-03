using System;

namespace ex5
{
    class Program
    {
        const int tamVet = 20;

        static void Main(string[] args)
        {
            int[] valores = new int[tamVet];
            int menor=0, i=0;
            
            for(int j=0; j<tamVet; j++)
            {
                Console.Write("Insira o valor no indice {0}: ", j);
                valores[j] = Int32.Parse(Console.ReadLine());

                if(j == 0)
                {
                    menor = valores[0];
                }
                else if(valores[j] < menor)
                {
                    menor = valores[j];
                    i=j;
                }
            }

            Console.WriteLine("O menor valor inserido é {0} no indice {1}", menor, i);
        }
    }
}
