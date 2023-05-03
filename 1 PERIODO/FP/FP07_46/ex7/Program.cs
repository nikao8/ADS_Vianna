using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o texto a ser encriptado: ");
            string txt = Console.ReadLine();

            Console.Write("Insira o valor da encriptação: ");
            int k = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Texto encriptado:");
            for(int i = 0; i < txt.Length; i++)
            {   
                Console.Write(Convert.ToChar(txt[i]+k));
            }
        }
    }
}
