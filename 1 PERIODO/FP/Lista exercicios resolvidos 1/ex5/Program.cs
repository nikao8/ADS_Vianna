using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros deseja inserir?: ");
            int qtd = Int32.Parse(Console.ReadLine());

            Console.WriteLine("A média aritmetica dos numeros inseridos é: {0}", CalculoMedia(qtd));
        }

        static double CalculoMedia(int qtd)
        {
            double n; int i =0;
            double media = 0;
            while(i < qtd)
            {
                Console.Write("Insira um numero: ");
                n = Double.Parse(Console.ReadLine());

                media += n; 
                i++;
            }
            return media/i;
        }
    }
}
