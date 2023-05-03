using System;

namespace ex7
{
    class Program
    {
        const int tamanho = 5;
        static void Main(string[] args)
        {
            int[] valores = new int[tamanho];


            int pcont=0,icont=0;

            for(int i=0; i<tamanho; i++)
            {
                Console.Write("{0} de {1}: ",i+1,tamanho);
                valores[i] = Convert.ToInt32(Console.ReadLine());

                if(valores[i] % 2 == 0)
                {
                    pcont++;
                }
                else
                {
                    icont++;
                }
            }

            int[] pares = new int[pcont];
            int[] impares = new int[icont];
            int j=0,x=0;

            for(int i = 0; i < valores.Length; i++)
            {
                if(valores[i] % 2 == 0)
                {
                    pares[j] = valores[i];
                    j++;
                }
                else
                {
                    impares[x] = valores[i];
                    x++;   
                }
            }

            Console.Write("\nValor do vetor V: ");
            for(int i = 0; i < valores.Length;i++)
            {
                if(i==valores.Length-1)
                {
                    Console.Write(valores[i]);
                }
                else
                {
                    Console.Write(valores[i] + ",");
                }
            }

            Console.Write("\nValor do vetor impares: ");
            for(int i = 0; i < impares.Length;i++)
            {
                if(i==impares.Length-1)
                {
                    Console.Write(impares[i]);
                }
                else
                {
                    Console.Write(impares[i] + ",");
                }
            }

            Console.Write("\nValor do vetor pares: ");
            for(int i = 0; i < pares.Length;i++)
            {
                if(i==pares.Length-1)
                {
                    Console.Write(pares[i]);
                }
                else
                {
                    Console.Write(pares[i] + ",");
                }
            }


        }
    }
}