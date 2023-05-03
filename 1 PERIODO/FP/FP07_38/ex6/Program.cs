using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INsira frase: ");
            string frase= Console.ReadLine();

            for(int i = 0; i < frase.Length; i++)
            {
                if(i == frase.Length - 1 || frase[i+1] == ' ')
                {
                    Console.Write(frase[i]);
                }
                else if(frase[i] != ' ')
                {
                    Console.Write(frase[i]+"-");
                }
                else
                {
                    Console.Write(" ");
                }
                
            }
        }
    }
}
