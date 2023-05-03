using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu texto: ");
            string txt = Console.ReadLine();

            Console.WriteLine("{0} vogais.", CalculaVogal(txt));
        }
        
        static int CalculaVogal(string txt)
        {
            int contadorVogal = 0;
            for(int i = 0;i < txt.Length; i++ )
            {
                if(txt[i] == 'a' || txt[i] == 'e' || txt[i] == 'i' || txt[i] == 'o' || txt[i] == 'u')
                {
                    contadorVogal++;
                }
            }
            return contadorVogal;
        }
    }
}
