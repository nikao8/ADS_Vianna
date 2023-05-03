using System;

namespace ex4
{
    class Program
    {

        static void CalcularOperacoes(int n1, int n2)
        {
            Console.WriteLine("Produto entre {0} e {1} é: {2}",n1,n2, n1*n2);
            Console.WriteLine("Soma entre {0} e {1} é: {2}",n1,n2, n1+n2);
            Console.WriteLine("Produto entre {0} e {1} é: {2}",n1,n2, n1-n2);
            Console.WriteLine("Produto entre {0} e {1} é: {2}",n1,n2, n1/n2);
            Console.WriteLine("Produto entre {0} e {1} é: {2}",n1,n2, n1%n2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro numero: ");
            int n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero: ");
            int n2 = Int32.Parse(Console.ReadLine());

            CalcularOperacoes(n1,n2);
        }
    }
}
