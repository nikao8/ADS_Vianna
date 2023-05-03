using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[7,5];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine("Linha {0}:", i+1);
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("Valor {0}: ", j+1);
                    mat[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nTerceira coluna da matriz: ");

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine(mat[i,2]);
            }
        }
    }
}
