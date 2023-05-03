using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.Write("Insira o valor de um dia da semana: entre 1-7 ");
            n = Int32.Parse(Console.ReadLine());

            switch(n)
            {
                case 1:
                    Console.WriteLine("Segunda-feira!");
                break;

                case 2:
                    Console.WriteLine("Terça-feira!");
                break;

                case 3:
                    Console.WriteLine("Quarta-feira!");
                break;

                case 4:
                    Console.WriteLine("Quinta-feira!");
                break;

                case 5:
                    Console.WriteLine("Sexta-feira!");
                break;

                case 6:
                    Console.WriteLine("Sábado!");
                break;

                case 7:
                    Console.WriteLine("Domingo!");
                break;

                default:
                    Console.WriteLine("Erro! insira um numero entre 1-7.");
                break;
            }
        }
    }
}
