using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Insira um numero inteiro e positivo para verificar se ele é primo ou não: ");
            n = Int32.Parse(Console.ReadLine());

            if(n<0)
            {
                Console.WriteLine("O numero inserido é negativo!");
                return;
            }
            else
            {
                bool resultado = VerificaPrimo(n);
                if(resultado == true)
                {
                    Console.WriteLine("O numero inserido é primo!");
                }
                else
                {
                    Console.WriteLine("O numero inserido não é primo!");
                }
            }

        }

        static bool VerificaPrimo(int num)
        {
            for(int i = 2; i < num; i++)
            {
                // var i iniciada com 2 pois quando o valor i = 1 entrasse na condicional if ele iria retornar false
                if(num % i == 0)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}
