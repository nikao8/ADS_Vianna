using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double aplicacao = 1500;
            double divida = 10000;
            while(aplicacao < divida)
            {
                aplicacao = aplicacao + (aplicacao * 0.04);
                divida = divida + (divida * 0.025);

                i++;
            }

            Console.WriteLine("São necessários {0} meses para cobrir a dívida", i);
        }
    }
}
