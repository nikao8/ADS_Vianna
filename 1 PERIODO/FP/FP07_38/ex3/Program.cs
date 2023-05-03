using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu texto: ");
            string txt = Console.ReadLine();
            int contadorVogal = 0;

            for(int i = 0;i < txt.Length; i++ )
            {
                if(txt[i] == 'a' || txt[i] == 'e' || txt[i] == 'i' || txt[i] == 'o' || txt[i] == 'u')
                {
                    contadorVogal++;
                }
            }

            Console.WriteLine("{0} vogais.", contadorVogal);
        }
    }
}
