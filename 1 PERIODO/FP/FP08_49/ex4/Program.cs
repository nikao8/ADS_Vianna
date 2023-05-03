using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1 = {{1,2,3},{4,5,6},{7,8,9},{10,11,12},{13,14,15},{16,17,18}};
            int[,] mat2 = new int[3,3];
            int[,] mat3 = new int[3,3];

            DivideMatriz(mat1,mat2,mat3);
            ImprimeMatriz(mat1,1);
            ImprimeMatriz(mat2,2);
            ImprimeMatriz(mat3,3);
        }

        static void DivideMatriz(int[,] mat1, int[,] mat2, int[,] mat3 )
        {
            int x = 3;
            for(int i = 0; i < mat2.GetLength(0); i++)
            {
                for(int j = 0; j < mat2.GetLength(1); j++)
                {
                    mat2[i,j] = mat1[i,j];
                }
            }

            for(int i = 0 ; x < mat1.GetLength(0); i++)
            {
                for(int j = 0; j < mat3.GetLength(1); j++)
                {
                    mat3[i,j] = mat1[x,j];
                }
                x++;
            }
        }

        static void ImprimeMatriz(int[,] mat, int numMat)
        {
            Console.WriteLine("\nMatriz {0}:\n", numMat);

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("{0,4} ", mat[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
