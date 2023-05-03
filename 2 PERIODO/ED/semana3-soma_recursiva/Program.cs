using System;

namespace semana4_soma_recursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = {1,2,5};
            int result = Somar(vetor,0,0);

            Console.WriteLine("Resultado da soma recursiva: " + result);
        }

        static int Somar(int[] vetor, int indice = 0, int inicio = 0)
        {
            if(indice >= vetor.Length)
            {
                return inicio;
            }
            else
            {
                inicio += vetor[indice];
                return Somar(vetor, indice + 1, inicio);
            }
        }
    }
}
