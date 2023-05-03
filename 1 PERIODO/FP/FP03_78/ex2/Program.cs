using System;

namespace ex2
{
    class Program
    {
        static void CalculoDescontoProduto(double valorProd, double desconto){
            double resultado =  valorProd - (valorProd * (desconto/100));
            Console.WriteLine("O valor do produto com desconto é de: {0}", resultado);
        }

        static void Main(string[] args)
        {
            Console.Write("Insira o valor do produto: ");
            double valorProduto = Double.Parse(Console.ReadLine());

            Console.Write("Insira o percentual do desconto: ");
            double valorDesconto = Double.Parse(Console.ReadLine());

            CalculoDescontoProduto(valorProduto, valorDesconto);
        }
    }
}
