using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu texto: ");
            string txt = Console.ReadLine();

            if(txt.Length <= 1)
            {
                Console.Write("Erro! string com um caractere ou menos");
                return;
            }

            for(int i = 0; i < txt.Length; i++)
            {
                if(i==0 || txt[i-1] == ' ')
                {
                    Console.Write(Convert.ToChar(txt[i] - 32));
                    continue;
                }
                Console.Write(txt[i]);
            }
        }
    }
}
