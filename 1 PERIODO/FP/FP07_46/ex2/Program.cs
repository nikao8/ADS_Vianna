using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o texto: ");
            string txt = Console.ReadLine();

            RetiraEspacoString(txt);
        }

        static void RetiraEspacoString(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                if(txt[i] == ' ')
                {
                    continue;
                }

                Console.Write(txt[i]);
            }
        }
    }
}
