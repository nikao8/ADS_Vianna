using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Nadador, insira sua idade: ");
            idade = Int32.Parse(Console.ReadLine());

            if(idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Infantil A");
            }
            else if(idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Infantil B");
            }
            else if(idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Juvenil A");
            }
            else if(idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Juvenil B");
            }
            else if(idade >= 18 && idade <= 30)
            {
                Console.WriteLine("Adulto");
            }
            else if(idade > 30)
            {
                Console.WriteLine("Sênior");
            }
            else
            {
                Console.WriteLine("Idade inválida");
            }
        }
    }
}
