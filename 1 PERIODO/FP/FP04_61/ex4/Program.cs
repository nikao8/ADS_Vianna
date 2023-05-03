using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,y,z;

            x = PrintaLer("x: ");
            y = PrintaLer("y: ");
            z = PrintaLer("z: ");

            if((x<(y+z)) && (y<(x+z)) && (z<(x+y)))
            {
                Console.WriteLine("os comprimentos de x={0} y={1} z={2} Formam um triangulo!",x,y,z);
            }
            else
            {
                Console.WriteLine("os comprimentos de x={0} y={1} z={2} NÃO formam um triangulo!",x,y,z);
            }
        }

        static double PrintaLer(string msg)
        {
            Console.Write(msg);
            return Double.Parse(Console.ReadLine());
        }
    }
}
