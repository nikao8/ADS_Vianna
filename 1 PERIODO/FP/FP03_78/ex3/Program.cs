using System;

namespace ex3
{
    class Program
    {
        
        static void CalculaAcrescimo(double valorProd, double valorAcres)
        {
            double resultado =  valorProd + (valorProd * (valorAcres/100));
            Console.WriteLine("O valor do produto com o acrescimo é de: {0}", resultado);
        }
        
        
        static void Main(string[] args)
        {
            Console.Write("Insira o valor do produto: ");
            double valorProd = Double.Parse(Console.ReadLine());

            Console.Write("Insira o percentual do acrescimo: ");
            double valorAcrescimo = Double.Parse(Console.ReadLine());

            CalculaAcrescimo(valorProd,valorAcrescimo);

        }
    }
}
