using System;

namespace ex5
{
    class Program
    {
        const int tamanho = 3;
        static void Main(string[] args)
        {
            int[] vet = new int[tamanho];
            int[,] mat = new int[tamanho,tamanho];

            Console.WriteLine("Preencha o vetor: ");
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Valor {0}:", i);
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine("Linha {0}: ", i);
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("Valor {0}: ",j);
                    mat[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            MultiplicaVetorPelaMatriz(vet,mat);
        }

        static void MultiplicaVetorPelaMatriz(int[] vet, int[,] mat)
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i,j] = vet[i] * mat[i,j];
                }
            }

            Console.WriteLine("Matriz multiplicada:");
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