using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1,n2;
            char caractere;

            Console.Write("Insira dois numero e um caractere de operação:\nNumero 1: ");
            n1 = Double.Parse(Console.ReadLine());

            Console.Write("Numero 2: ");
            n2 = Double.Parse(Console.ReadLine());

            Console.Write("Insira um caractere de operação: ");
            caractere = Char.Parse(Console.ReadLine());


            switch(caractere)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}",n1,n2,n1+n2);
                break; 

                case '-':
                    Console.WriteLine("{0} - {1} = {2}",n1,n2,n1-n2);
                break;

                case '*':
                    Console.WriteLine("{0} * {1} = {2}",n1,n2,n1*n2);
                break;

                case '/':
                    Console.WriteLine("{0} / {1} = {2}",n1,n2,n1/n2);
                break;   

                default:
                    Console.WriteLine("Insira um caractere válido: (* - + /)");
                break;
            }
        }
    }
}
