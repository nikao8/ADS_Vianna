using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1,n2;
            Console.Write("Insira o valor do primeiro numero: ");
            n1 = Double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do segundo numero: ");
            n2 = Double.Parse(Console.ReadLine());

            DivisaoDoisNumeros(n1,n2);
        }

        static void DivisaoDoisNumeros(double n1, double n2)
        {
            if(n2 != 0)
            {
                Console.Write("Resultado de {0} / {1}: {2}",n1,n2,n1/n2);        
            }
            else
            {
                Console.Write("O segundo numero não pode ser igual a 0!");
            }
        }
    }
}
