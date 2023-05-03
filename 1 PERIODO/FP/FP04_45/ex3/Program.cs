using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Insira um numero e descubra se ele é divisivel por 2\n--> ");
            n = Int32.Parse(Console.ReadLine());

            if((n % 2 == 0) && (n % 3 == 0))
            {
                Console.WriteLine("{0} é divisivel por 2 e por 3 simultaneamente!", n);
            }
            else
            {
                Console.WriteLine("{0} não é divisivel simultaneamente por 2 e por 3!", n);
            }
        }
    }
}
