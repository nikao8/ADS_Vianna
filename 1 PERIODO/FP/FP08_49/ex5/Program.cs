using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] mat = new char[5,10];
            int contadorA = 0;
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("Insira um valor: ");
                    mat[i,j] = Convert.ToChar(Console.ReadLine());

                    if(mat[i,j] == 'a' || mat[i,j] == 'A')
                    {
                        contadorA++;
                    }
                }
            }

            Console.WriteLine("As letras 'a' ou 'A' foram digitadas {0} vezes", contadorA);
        }
    }
}
