using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            char caractere;
            
            Console.Write("Insira um caractere: ");
            caractere = Char.Parse(Console.ReadLine());

            switch (caractere)
            {
                case '<':
                    Console.WriteLine("Sinal de menor");
                break;

                case '>':
                    Console.WriteLine("Sinal de maior");
                break;

                case '=':
                    Console.WriteLine("Sinal de igual");
                break;

                default:
                    Console.WriteLine("Outro caractere.");
                break;
            }
        }
    }
}
