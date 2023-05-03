using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; double i=1;
            double e = 0;
            
            Console.WriteLine("Insira o valor de um numero inteiro e positivo: ");
            num = Int32.Parse(Console.ReadLine());

            while(i < num)
            {
                e = e + 1/i;
                i++;
            }
            Console.WriteLine("E = {0}", e);
        }
    }
}
