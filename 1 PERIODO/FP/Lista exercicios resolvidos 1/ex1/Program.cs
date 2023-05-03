using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um numero e descubra se ele é par ou não: ");
            int num = Int32.Parse(Console.ReadLine());

            CalculaPar(num);
        }

        static void CalculaPar(int n)
        {
            if(n % 2 == 0)
            {
                Console.WriteLine("{0} é PAR!", n);
            }
            else
            {
                Console.WriteLine("{0} é IMPAR!", n);
            }
        }
    }
}
