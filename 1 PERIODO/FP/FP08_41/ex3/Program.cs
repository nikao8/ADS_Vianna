using System;

namespace ex3
{
    class Program
    {
        const int tam = 5;
        static void Main(string[] args)
        {
            int[,] mat = new int[tam,tam];

            Identidade(mat);
            ImprimeMatIdentidade(mat);
        }

        static void Identidade(int[,] mat)
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                mat[i,i] = 1; 
            }

            /*
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        mat[i,j] = 1;
                    }
                    else
                    {
                        mat[i,j] = 0;
                    }
                }
            }
            */
        }

        static void ImprimeMatIdentidade(int[,] mat)
        {
            Console.WriteLine("Matriz identidade: ");
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
