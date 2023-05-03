using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet1 = {1,2,3,4,5,6,7,8,9,10};
            double[] vet2 = {11,12,13,14,15,16,17,18,19,20};
            double[] vet3 = {21,22,23,24,25,26,27,28,29,30};

            GeraMatrizColVet(vet1,vet2,vet3);
        }

        static void  GeraMatrizColVet(double[] vet1, double[] vet2, double[] vet3)
        {
            double[,] mat = new double[10,3];

            for(int i = 0; i < mat.GetLength(1); i++)
            {
                for(int j = 0; j < mat.GetLength(0); j++)
                {
                    if(i == 0)
                    {
                        mat[j,i] = vet1[j];
                    }
                    else if(i == 1)
                    {
                        mat[j,i] = vet2[j];
                    }
                    else if(i == 2)
                    {
                        mat[j,i] = vet3[j];
                    }
                }
            }

            ImprimeMatriz(mat);
        }

        static void ImprimeMatriz(double[,] mat)
        {

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
