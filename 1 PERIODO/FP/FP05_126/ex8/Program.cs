using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um numero para o calculo do fatorial: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0}! = {1}",n, CalculaFatorial(n));
        }

        static int CalculaFatorial(int num)
        {
            int aux = num;
            int fatorial = 1;

            while(aux > 0)
            {
                fatorial = fatorial * aux;
                aux--;
            }

            return fatorial;
        }
    }
}
