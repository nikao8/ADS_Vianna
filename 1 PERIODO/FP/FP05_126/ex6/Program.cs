using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int i = 0;
            
            int maior; int menor;

            Console.WriteLine("Insira um numero: ");
            int n = Int32.Parse(Console.ReadLine());
            
            menor = n;
            maior= n;

            while (true)
            {
                Console.WriteLine("Insira um numero: ");
                n = Int32.Parse(Console.ReadLine());

                if(n == 0)
                {
                    Console.WriteLine("O maior valor é: {0}\nO menor valor é {1}", maior, menor);
                    return;
                }

                if(n < menor)
                {
                    menor = n;
                }
                else if(n > maior)
                {
                    maior = n;
                }
            }
        }
    }
}
