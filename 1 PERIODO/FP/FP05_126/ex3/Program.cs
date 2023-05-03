using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double chico = 1.50;
            double ze = 1.40;
            int i=0;
            
            while(ze<=chico)
            {
                chico = chico + 0.02;
                ze = ze + 0.03;
                i++;
            }

            Console.WriteLine("A quantidade de anos necessárias para que zé seja maior do que chico é de {0} anos", i);

        }
    }
}
