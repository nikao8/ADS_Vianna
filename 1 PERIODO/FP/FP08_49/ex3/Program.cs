using System;

namespace ex3
{
    class Program
    {
        const int tam = 10;
        static void Main(string[] args)
        {
            int[,] mat = new int[tam,tam];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine("Linha {0}:", i+1);
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("Valor {0}: ", j+1);
                    mat[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz:\n");

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("{0,4} ", mat[i,j]);
                }

                Console.WriteLine();
            }


            Console.WriteLine("\nMaior valor da matriz: {0}", MaiorValor(mat));
            Console.Write("Menor valor da matriz: {0}", MenorValor(mat));
        }

        static int MaiorValor(int[,] mat)
        {
            int maior = mat[0,0];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    if(mat[i,j] > maior)
                    {
                        maior = mat[i,j];
                    }
                }
            }
            
            return maior;
        }

        static int MenorValor(int[,] mat)
        {
            int menor = mat[0,0];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    if(mat[i,j] < menor)
                    {
                        menor = mat[i,j];
                    }
                }
            }
            
            return menor;
        }
    }
}
