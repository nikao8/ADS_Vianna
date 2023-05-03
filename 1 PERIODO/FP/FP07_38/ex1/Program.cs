using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu texto: ");
            string txt = Console.ReadLine();
            int cont=0;

            for(int i = 0; i < txt.Length; i++)
            {
                if(txt[i] == ' ')
                {
                    cont++;
                }
            }
            
            Console.WriteLine("O texto possui {0} espaços.", cont);
        }
    }
}
