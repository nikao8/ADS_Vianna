using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor do produto: ");
            double valorProd = Double.Parse(Console.ReadLine());

            ImprimeValor(valorProd);
        }

        static void ImprimeValor(double valor)
        {
            if(valor >= 100.0 && valor <= 300.0)
            {
                valor = valor - (valor * 0.20);
            }
            else if(valor > 300.0)
            {
                valor = valor - (valor * 0.30);
            }

            Console.WriteLine("O valor final do produto: {0}", valor);
        }
    }
}
