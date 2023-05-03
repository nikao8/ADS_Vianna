using System;

namespace ex10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Informe o tamanho do vetor: ");
            int tamanhoVet = Convert.ToInt32(Console.ReadLine());

            int [] valores = new int [tamanhoVet];

            for(int i = 0; i<valores.Length; i++)
            {
                Console.Write("Valores do vetor {0}/{1}: ",i+1,tamanhoVet);
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i<tamanhoVet; i++)
            {
                Console.Write("{0}",valores[i]);
            }

            Console.WriteLine();
            ImprimeCrescente(valores,tamanhoVet);
        }


        static void ImprimeCrescente(int[]valores,int tamanhoVet)
        {
            int j,aux;

            for (j = 0; j<tamanhoVet; j++)
            {
                for (int i = 0; i<tamanhoVet-1; i++)
                {
                    if (valores[i] > valores [i+1]) 
                    {
                        aux = valores[i];
                        valores[i]=valores[i+1]; 
                        valores[i+1]=aux; 
                    }
                }
            }
            for(int i = 0; i<tamanhoVet; i++)
            {
                Console.Write("{0}",valores[i]);
            }
        }
    }
}
