using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1,n2;

            Console.Write("Insira o valor do primeiro numero: ");
            n1 = Double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do segundo numero: ");
            n2 = Double.Parse(Console.ReadLine());     

            if(n1 >= 0 && n2 >= 0)
            {
                Console.WriteLine("Valores são válidos.");
            }
            else
            {
                Console.WriteLine("Valores não são válidos.");
            }
        }
    }
}
