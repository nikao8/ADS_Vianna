using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double[15];
            double menor = 0;
            int indice = 0;

            Console.Write("Preencha o indice 0 de {0}: ", valores.Length);
            valores[0] = Double.Parse(Console.ReadLine());

            menor = valores[0];
            for(int i = 1; i < valores.Length; i++)
            {
                Console.Write("Preencha o indice {0} de {1}: ", i,valores.Length);
                valores[i] = Double.Parse(Console.ReadLine());

                if(valores[i] < menor)
                {
                    menor = valores[i];
                    indice = i;
                }                
            }

            Console.WriteLine("O menor valor foi de {0} no índice {1}.", menor,indice);
        }
    }
}
