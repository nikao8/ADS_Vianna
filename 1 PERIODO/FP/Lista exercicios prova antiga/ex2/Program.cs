using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira quantos números voce deseja inserir: ");
            int qtd = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Maior numero: {0}", CalculaMaior(qtd));
        }

        static double CalculaMaior(int qtd)
        {
            int i = 1;
            double numero,maior;
            
            Console.Write("Insira o {0} numero: ", i);
            numero = Double.Parse(Console.ReadLine());
            
            maior = numero;

            while(i < qtd)
            {
                i++;

                Console.Write("Insira o {0} numero: ", i);
                numero = Double.Parse(Console.ReadLine());

                if(numero > maior)
                {
                    maior = numero;
                }           
            }

            return maior;
        }
    }
}
