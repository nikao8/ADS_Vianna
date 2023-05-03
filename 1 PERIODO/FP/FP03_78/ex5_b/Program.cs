using System;

namespace ex5_b
{
    class Program
    {
        static double CalculaPerimetro(double v1a,double v1b,double v2a,double v2b, double v3a,double v3b)
        {
            
            double dAB, dAC, dBC, perimetro;

            dAB = Math.Sqrt(Math.Pow((v2a - v1a),2) + Math.Pow((v2b - v1b),2));
            
            dAC = Math.Sqrt(Math.Pow((v3a - v1a),2) + Math.Pow((v3b - v1b),2));

            dBC = Math.Sqrt(Math.Pow((v3a - v2a),2) + Math.Pow((v3b - v2b),2));

            perimetro = dAB+dAC+dBC;

            return perimetro;
        }

        static void Main(string[] args)
        {
           double v1a,v1b,v2a,v2b,v3a,v3b;

           Console.Write("Insira o valor de X vertice A: ");
           v1a = Double.Parse(Console.ReadLine());
           Console.Write("Insira o valor de Y do vertice A: ");
           v1b = Double.Parse(Console.ReadLine());
           
           Console.Write("Insira o valor de X do vertice B: ");
           v2a = Double.Parse(Console.ReadLine());
           Console.Write("Insira o valor de Y do vertice B: ");
           v2b = Double.Parse(Console.ReadLine());
           
           Console.Write("Insira o valor de X do vertice C: ");
           v3a = Double.Parse(Console.ReadLine());
           Console.Write("Insira o valor de Y do vertice C: ");
           v3b = Double.Parse(Console.ReadLine());

            Console.WriteLine("O valor do perimetro baseado nos vertices especificados é de: {0}", CalculaPerimetro(v1a,v1b,v2a,v2b,v3a,v3b));
        }
    }
}

