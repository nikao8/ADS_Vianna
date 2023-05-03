using System;

namespace ex5
{
    class Program
    {
        const int tamVet = 15;
        static void Main(string[] args)
        {
            int[] valores = new int[tamVet];
            int buscar;
            
            for(int i = 0;i < valores.Length; i++)
            {   
                Console.Write("Insira o valor no indice {0} de {1}: ", i, tamVet-1);
                valores[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Insira o valor a ser buscado no vetor: ");
            buscar = Int32.Parse(Console.ReadLine());

            Console.WriteLine("O valor buscado foi encontrado no indice {0}.", ProcuraValor(valores, buscar));

        }

        static int ProcuraValor(int[] valores, int buscar)
        {
            int indice = -1;
            for(int i = 0; i < valores.Length; i++)
            {
                if(buscar == valores[i])
                {
                    indice = i;
                }
            }

            return indice;
        }
    }
}
