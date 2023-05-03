using System;

namespace ex1
{
    class Program
    {
        const int linhasColunas = 3;
        static void Main(string[] args)
        {
            int[,] mat1 = new int [linhasColunas,linhasColunas];
            int[,] mat2 = new int [linhasColunas,linhasColunas];

            Console.WriteLine("MATRIZ 1: ");
            LeMatriz(mat1);
            Console.WriteLine("\nMATRIZ 2: ");
            LeMatriz(mat2);
            ImprimeMatriz(mat1,mat2);
        }

        static void LeMatriz(int[,] mat)
        {
            for(int i = 0; i < linhasColunas; i++)
            {
                Console.WriteLine("\nLinha {0}:\n", i+1);
                for(int j = 0; j < linhasColunas; j++)
                {
                    Console.Write("Valor {0}: ", j+1);
                    mat[i,j] = Int32.Parse(Console.ReadLine());
                }
            }
        }

        static void ImprimeMatriz(int[,] mat1, int[,] mat2)
        {
            double soma = 0;
            Console.WriteLine("\nA mat1 somada com a mat2 é:\n");
            for(int i = 0; i < linhasColunas; i++)
            {
                for(int j = 0; j < linhasColunas; j++)
                {
                    soma = mat1[i,j] + mat2[i,j];
                    Console.Write(soma + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
