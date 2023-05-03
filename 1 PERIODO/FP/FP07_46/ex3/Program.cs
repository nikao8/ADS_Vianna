using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o texto: ");
            string txt = Console.ReadLine();

            ImprimeEstatisticaString(txt);
        }

        static void ImprimeEstatisticaString(string txt)
        {
            Console.WriteLine("Vogais: {0}\nConsoantes: {1}\nOutros caracteres: {2}", Vogais(txt), Consoantes(txt), OutrosCaracteres(txt));
        }

        static int Vogais(string txt)
        {
            int vogais = 0;

            txt = txt.ToLower();

            for(int i = 0; i < txt.Length; i++)
            {
                if(txt[i] == 'a' || txt[i] == 'e' || txt[i] == 'i' || txt[i] == 'o' || txt[i] == 'u')
                {
                    vogais++;
                }
            }

            return vogais;
        }

        static int OutrosCaracteres(string txt)
        {
            int caracteres = 0;

            txt = txt.ToUpper();

            for(int i = 0; i < txt.Length; i++)
            {
                if(txt[i] < 65 || txt[i] > 90)
                {
                    caracteres++;
                }

            }

            return caracteres;
        }

        static int Consoantes(string txt)
        {
            return txt.Length - (OutrosCaracteres(txt) + Vogais(txt));
        }
    }
}
