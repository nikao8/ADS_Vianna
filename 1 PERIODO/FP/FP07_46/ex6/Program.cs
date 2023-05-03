using System;

namespace ex6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Escreva uma palavra para saber se a memsa é um palíndrome: ");
            string palavra = Console.ReadLine();

            Console.Write("{0}",DescobrePalindromo(palavra));
        }


        static bool DescobrePalindromo(string palavra)
        {
            for (int i = 0, j = palavra.Length - 1; i < j; i++, j--)
            {
                if(palavra[i] != palavra[j])
                {
                    return false;
                }
            }

            return true;
        }
    }    
}
