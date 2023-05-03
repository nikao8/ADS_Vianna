using System;

namespace ex1
{
    class Program
    {
        static void CalcularMediaAritimetica(double n1,double n2, double n3){
            Console.WriteLine("O resultado da média aritimetica é {0:N2}",(n1+n2+n3)/3);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insira 3 valores reais para calculo da media aritimetica");
            double n1 = Int32.Parse(Console.ReadLine());
            double n2 = Int32.Parse(Console.ReadLine());
            double n3 = Int32.Parse(Console.ReadLine());

            CalcularMediaAritimetica(n1,n2,n3);

        }
    }
}
