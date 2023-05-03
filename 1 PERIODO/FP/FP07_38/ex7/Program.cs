using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o texto a ser invertido: ");
            string txt = Console.ReadLine();

            InverteString(txt);
        }   

        static void InverteString(string txt)
        {
            for(int i = txt.Length - 1; i >= 0; i--)
            {
                Console.Write(txt[i]);
            }
        }
    }
}
