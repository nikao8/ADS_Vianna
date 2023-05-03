using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu texto: ");
            string txt = Console.ReadLine();
            
            Console.WriteLine("O texto possui {0} espaços.", CalculaEspacos(txt));
        }

        static int CalculaEspacos(string txt)
        {
            int cont=0;
            for(int i = 0; i < txt.Length; i++)
            {
                if(txt[i] == ' ')
                {
                    cont++;
                }
            }
            
            return cont;
        }
    }
}
