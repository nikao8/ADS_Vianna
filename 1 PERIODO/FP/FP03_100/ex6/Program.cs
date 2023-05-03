using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1,p2;
            
            Console.Write("Insira a nota da Prova 1: ");
            p1 = Double.Parse(Console.ReadLine());

            Console.Write("Insira a nota da Prova 2: ");
            p2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Para o aluno ser aprovado, ele tem que tirar no minimo {0:N2} na P3", CalculaNotaP3(p1,p2));
        }
        // gambiarra ajustar
        static double CalculaNotaP3(double p1, double p2)
        {
            double i = 0;
            while(((p1+p2)+(2.0*i))/4 < 5.0)
            {
                i = i + 0.05;
            }  
            
            return i - 0.05;
        }
    }
}
