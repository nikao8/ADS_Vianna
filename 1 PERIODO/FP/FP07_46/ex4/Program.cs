using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o texto: ");
            string txt = Console.ReadLine();

            string vogais = "", consoantes = "";

            txt = txt.ToLower();
            for(int i = 0; i < txt.Length; i++)
            {
                
                if(txt[i] == 'a' || txt[i] == 'e' || txt[i] == 'i' || txt[i] == 'o' || txt[i] == 'u')
                {
                    vogais += txt[i];
                }
                else
                {
                    consoantes += txt[i];
                }
            }

            Console.WriteLine("String vogais: {0}\nString consoantes: {1}",vogais,consoantes);
        }
    }
}
