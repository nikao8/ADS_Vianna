using System;

namespace ex2
{
    class Program
    {
        const int tamanho = 3;
        static void Main(string[] args)
        {
            Console.WriteLine("Preencha a matriz: ");
            int[,] mat = new int[tamanho,tamanho];
            int[,] mat2 = new int[tamanho,tamanho];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine("Linha {0}: ", i);
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("Valor {0}: ",j);
                    mat[i,j] = Convert.ToInt32(Console.ReadLine());
                    mat2[j,i] = mat[i,j];
                }
            }
         
            Console.WriteLine("\nMatriz 1:");
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz 2 invertida:");
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat2[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
