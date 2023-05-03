using System;
using System.Collections.Generic;
namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n=0; int i = 0;
            List<int> listaNumeros = new List<int>();

            while(i<10)
            {
                n = LeVar("Insira o numero "+ (i+1) + ": " );
                listaNumeros.Add(n);
                
                i++;
            }

            listaNumeros.Sort();
            Console.WriteLine("O maior numero é: {0}\nO menor numero é {1}",listaNumeros[listaNumeros.Count - 1], listaNumeros[0]);     
            */
            int i=1;
            double maior=0,num,menor=0;

            num=LeVar("Digite algum numero: ");
             
            maior=num;
            menor=num;

            while(i<10)
            {
                num=LeVar("Digite algum numero: ");
                
                if(num>maior)
                {
                    maior=num;
                }else if(num<menor)
                {
                    menor=num;
                }
                i++;

            }
            Console.WriteLine("Maior num: {0}\nMenor num: {1}.",maior,menor);

        }
        
        static int LeVar(string mensagem)
        {
            Console.Write(mensagem);
            return Int32.Parse(Console.ReadLine());
        }
    }
}
