using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat1 = new double[,] {{4,5}, {1,8}, {9,10.5}};

            Console.WriteLine("Soma dos elementos da matriz: {0}", SomaMatriz(mat1));
        }

        static double SomaMatriz(double[,] mat)
        {
            double soma = 0;
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    soma += mat[i,j];
                }
            }

            return soma;
        }
    }
}
