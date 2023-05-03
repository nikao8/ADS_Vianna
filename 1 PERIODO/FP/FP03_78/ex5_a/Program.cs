using System;

namespace ex5_a
{
    class Program
    {
        static void CalculaDistancia(double x1,double y1,double x2, double y2)
        {
            double distancia = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));

            Console.WriteLine("A distancia entre as cordenadas é de: {0}", distancia);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insira a cordenada de x1 e y1: ");
            double x1 = Double.Parse(Console.ReadLine());
            double y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a cordenada de x2 e y2: ");
            double x2 = Double.Parse(Console.ReadLine());
            double y2 = Double.Parse(Console.ReadLine());

            CalculaDistancia(x1,y1,x2,y2);
        }
    }
}
