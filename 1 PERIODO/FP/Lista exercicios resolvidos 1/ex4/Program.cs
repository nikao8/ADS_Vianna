using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vogal inserida: {0}", LeChar());
        }

        static char LeChar()
        {
            char c;
            do
            {
                Console.Write("Insira um caractere: ");
                c = Char.Parse(Console.ReadLine());
            }while(c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u');

            return c;
        }
    }
}
