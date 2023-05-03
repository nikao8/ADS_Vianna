using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3,4];
            
            Console.Write("Insira o valor do escalar: ");
            int escalar = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine("Linha {0}:\n", i+1);
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("Valor {0}: ", j+1);
                    mat[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            MatMultiplicadaEscalar(mat, escalar);
        }

        static void MatMultiplicadaEscalar(int[,] mat, int escalar)
        {
            int[,] matEscalada = new int[3,4];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    matEscalada[i,j] = mat[i,j] * escalar;
                }
            }

            ImprimeMatEscalar(matEscalada);
        }

        static void ImprimeMatEscalar(int[,] mat)
        {
            Console.WriteLine("Matriz escalar:");
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", mat[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
