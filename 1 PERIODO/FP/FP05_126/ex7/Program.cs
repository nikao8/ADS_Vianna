using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 50; i <= 150; i++)
            {
                Console.WriteLine("{0}°F em °C: {1:N2}", i, ((i-32)/(1.8)));
            }
        }
    }
}
