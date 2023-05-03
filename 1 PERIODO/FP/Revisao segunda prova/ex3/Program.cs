using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de linhas da matriz: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a quantidade de colunas da matriz: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] mat = new int[rows,cols];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine("Linha {0}:\n", i+1);
                for(int j = 0; j < mat.GetLength(1); j++)
                {   
                    Console.Write("Valor {0}: ",j+1);
                    mat[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {   
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("A soma das diagonais é:");
            ImprimeDiagSecMatriz(mat);
        }

        static void ImprimeDiagSecMatriz(int[,] mat)
        {
            if(mat.GetLength(0) != mat.GetLength(1))
            {
                Console.WriteLine("A matriz precisa ser quadrada!");
            }
            else
            {

                double soma = 0;
                for(int i = 0; i < mat.GetLength(0); i++)
                {
                    for(int j = 0; j < mat.GetLength(1); j++)
                    {
                        if(i+j == mat.GetLength(0)-1)
                        {
                            soma += mat[i,j];
                        }
                    }
                }

                Console.Write("\n{0}",soma);   
            }
        }
    }
}
