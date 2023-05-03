using System;

namespace ex1
{
    class Program
    {

        static void CalculaTempo(int segundos)
        {
            int minutos,horas,segundos1;

            horas = segundos / 3600;
            minutos = (segundos % 3600) / 60;
            segundos1 = (segundos % 3600) % 60;

            Console.WriteLine("{0}hr {1}min {2}seg",horas,minutos,segundos1);
        }

        static void Main(string[] args)
        {
            Console.Write("INSIRA O TEMPO EM SEGUNDOS: ");
            int segundos = Int32.Parse(Console.ReadLine());

            CalculaTempo(segundos);
        }
    }
}
