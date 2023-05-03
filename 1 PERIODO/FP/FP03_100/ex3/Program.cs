using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos,dias,meses;
            Console.Write("Referente a sua idade, insira:\nAnos: ");
            anos = Int32.Parse(Console.ReadLine());

            Console.Write("Meses: ");
            meses = Int32.Parse(Console.ReadLine());

            Console.Write("Dias: ");
            dias = Int32.Parse(Console.ReadLine());

            Console.WriteLine("A sua idade em dias é de: {0} dias", CalculaIdadeDias(anos,meses,dias));
        }

        static int CalculaIdadeDias(int anos,int meses,int dias)
        {
            return (anos * 365) + (meses * 30) + dias;
        }

    }
}
