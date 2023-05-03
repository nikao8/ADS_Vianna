using System;

namespace semana1_algoritimo_recursivo
{
    /*
        RESOLVENDO FATORIAL COM RECURSIVIDADE:
        LÓGICA:

        4! = 4 * 3 * 2 * 1
        3! = 3 * 2 * 1
        2! = 2 * 1
        1! = 1
        0! = 1

        Logo:

        4! = 4 * 3!
        3! = 3 * 2!
        2! = 2 * 1!
        1! = 1 * 0!
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o numero para descobrir seu fatorial: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O fatorial de {0} é: {1}.", n, Fatorial(n));
        }

        static int Fatorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            else
            {
                return n * Fatorial(n-1);
            }
        }
    }
}
