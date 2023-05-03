using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double s0,v0,a,t;

            Console.Write("Insira:\n\nPosição inicial (s0): ");
            s0 = Double.Parse(Console.ReadLine());
            
            Console.Write("Velocidade inicial (v0): ");
            v0 = Double.Parse(Console.ReadLine());

            Console.Write("Aceleração (a): ");
            a = Double.Parse(Console.ReadLine());

            Console.Write("Instante (t): ");
            t = Double.Parse(Console.ReadLine());

            CalculaEquacaoPosicaoVelocidade(s0,v0,a,t);
        }

        static void CalculaEquacaoPosicaoVelocidade(double s0,double v0, double a, double t)
        {
            double s,v;

            s = (s0 + v0 * t) + (a* t * t)/2;
            v = v0 + (a * t);
            
            Console.Clear();
            Console.WriteLine("Posição: {0}\nVelocidade: {1}",s,v );
        }
    }
}
