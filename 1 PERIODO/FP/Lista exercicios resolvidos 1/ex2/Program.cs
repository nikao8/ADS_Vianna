using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um numero e descubra se ele é par ou não: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} é um número {1}", num, CalculaPar(num));
        }

        static string CalculaPar(int n)
        {
            if(n % 2 == 0)
            {
                return "PAR";
            }
            else
            {
                return "IMPAR";
            }
        }
    }
}
