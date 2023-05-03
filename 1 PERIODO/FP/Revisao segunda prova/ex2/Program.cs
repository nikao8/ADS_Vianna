using System;
using System.Text;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("insira o texto: ");
            string txt = Console.ReadLine();

            Console.Write("O texto somente com consoantes é: {0}", Consoantes(txt));
        }

        static string Consoantes(string txt)
        {
            //string consoantes = "";
            StringBuilder consoantes = new StringBuilder("");
            char aux; int x = 0;
            for(int i = 0; i < txt.Length; i++)
            {
                aux = CharLower(txt[i]);
                if(aux != 'a' && aux != 'e' && aux != 'i' && aux != 'o' && aux != 'u')
                {
                    consoantes.Insert(x,txt[i]); /* Com o metodo insert é necessário passar o indice do string para inserir o caractere passado no outro parametro,
                    nesse caso como o indice i vai variar por conta do if foi criado um novo contador que incrementa dentro da condicional */

                    //consoantes.Append(txt[i]); // Metodo apend funciona neste caso pois a string inicial foi declarada como vazia
                    x++;
                }
            }

            return consoantes.ToString();
        }

        // Função criada para passar os caracteres para minusculo
        static char CharLower(char c)
        {
            if(c >= 65 && c <= 90)
            {
                return Convert.ToChar(c + 32);
            }
            return c;
        }
        
    }
}
