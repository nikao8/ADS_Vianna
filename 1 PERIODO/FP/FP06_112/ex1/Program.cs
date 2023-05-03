using System;

namespace ex1
{
    class Program
    {
        const int tamVet = 5;
        static void Main(string[] args)
        {
            double[] numeros = new double[tamVet];
            
            for(int i =0;i<tamVet;i++)
            {
                Console.Write("{0} numero de {1}: ", i+1,tamVet);
                numeros[i] = Double.Parse(Console.ReadLine());
            }

            Console.Write("\nInsira o valor do escalar: ");
            double escalar = Double.Parse(Console.ReadLine());


            Console.WriteLine("\nVetor escalar: ");

            for(int i = 0; i<tamVet; i++)
            {
                numeros[i] = numeros[i] * escalar;
                
                if(i==tamVet-1)
                {
                    Console.Write(numeros[i]);
                }
                else
                {
                    Console.Write("{0}, ",numeros[i]);
                }
            }
        }
    }
}
