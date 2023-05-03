using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            
            Console.Write("Insira o primeiro numero: ");
            n1 = Int32.Parse(Console.ReadLine());

            Console.Write("Insira o segundo numero: ");
            n2 = Int32.Parse(Console.ReadLine());

            if(n1 > n2){
                Console.WriteLine("{0} é maior que {1}", n1,n2);
            }
            else if(n2 > n1)
            {
                Console.WriteLine("{0} é maior que {1}", n2,n1);
            }
            else
            {
                Console.WriteLine("{0} é igual a {1}", n1,n2);
            }
        }
    }
}
