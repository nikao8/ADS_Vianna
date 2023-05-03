using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Insira um numero inteiro e positivo: ");
            num = Int32.Parse(Console.ReadLine());
            
            double e = 1;
            
            for(int i = 1; i < num; i++)
            {
                e = e + (1.0/CalculaFatorial(i));
            }

            Console.WriteLine("E = {0}", e);
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
