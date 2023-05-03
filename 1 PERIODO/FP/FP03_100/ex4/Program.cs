using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1,n2;
            
            Console.Write("Insira o primeiro valor para o calculo: ");
            n1 = Double.Parse(Console.ReadLine());

            Console.Write("Agora insira o segundo valor para o calculo: ");
            n2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("({0}² + {1}¹/²) = {2:N2}",n1,n2,CalculaFuncao(n1,n2));
        }

        static double CalculaFuncao(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
        }
    }
}
