using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Insira um numero e descubra se ele é divisivel por 2\n--> ");
            n = Int32.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("{0} é divisivel por 2!", n);
            }
            else
            {
                Console.WriteLine("{0} não é divisivel por 2!", n);
            }
        }
    }
}
