using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o raio da esfera: ");
            double raio = Double.Parse(Console.ReadLine());

            Console.Write("O volume da esfera é {0:N2}", CalculaVolumeEsfera(raio));
        }

        static double CalculaVolumeEsfera(double raio)
        {
            return (4 * 3.14 * Math.Pow(raio,3)) / 3;
        }
    }
}
