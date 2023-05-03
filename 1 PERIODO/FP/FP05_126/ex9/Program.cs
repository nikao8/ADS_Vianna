using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=0; int n2 =1;
            int acumulador = 1;
            
            Console.WriteLine("Insira um numero: ");
            int numero = Int32.Parse(Console.ReadLine());
            
            Console.Write("0 1 ");
            for(int i = 3;i <= numero; i++)
            {
                acumulador = n1 + n2;
                n1 = n2;
                n2 = acumulador;

                //Console.Write("0 1 {0}", acumulador);

                Console.Write("{0} ",acumulador);
            }
            
            //Console.WriteLine(acumulador);

        }
    }
}
