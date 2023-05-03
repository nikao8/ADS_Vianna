using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LeNumero());
        }

        static int LeNumero()
        {
            int n;
            do
            {
                Console.Write("Insira um numero: ");
                n = Int32.Parse(Console.ReadLine());
            }while (n < 0);

            return n;
        }
    }
}
