using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro texto: ");
            string txt1 = Console.ReadLine();

            Console.Write("Insira o segundo texto: ");
            string txt2 = Console.ReadLine();
            
            string txt3 = txt1 + txt2;

            Console.WriteLine("O texto 1 concatenado com o texto 2 é: {0}", txt3);
        }
    }
}