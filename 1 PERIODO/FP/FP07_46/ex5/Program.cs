using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o texto: ");
            string txt = Console.ReadLine();

            Console.Write("Insira o caractere para remover do texto: ");
            char carac = Char.Parse(Console.ReadLine());

            for(int i = 0; i < txt.Length; i++)
            {
                if(txt[i] != carac)
                {
                    Console.Write(txt[i]);
                }
            }
        }
    }
}
