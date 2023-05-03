using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int codProd;
            Console.Write("Insira o código do produto: ");
            codProd = Int32.Parse(Console.ReadLine());

            if(codProd >= 1  && codProd <= 20)
            {
                Console.WriteLine("Europa");
            }
            else if(codProd >= 21  && codProd <= 40)
            {
                Console.WriteLine("Ásia");
            }
            else if(codProd >= 41  && codProd <= 60)
            {
                Console.WriteLine("América");
            }
            else if(codProd >= 61  && codProd <= 80)
            {
                Console.WriteLine("África");
            }
            else if(codProd >= 81)
            {
                Console.WriteLine("Paraguai");
            }
            else
            {
                Console.WriteLine("Insira um número maior que 1");
            }
        }
    }
}
