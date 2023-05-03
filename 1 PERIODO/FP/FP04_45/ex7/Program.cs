using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Write("Insira sua idade: ");
            idade = Int32.Parse(Console.ReadLine());

            if(idade < 13)
            {
                Console.WriteLine("Criança");
            }
            else if(idade >= 13 && idade < 20)
            {
                Console.WriteLine("Adolescente");
            }
            else if(idade >= 20 && idade < 60)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("Idoso");
            }
        }
    }
}
