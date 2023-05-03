using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("Forma de pagamento:\n\n- À vista.\n\n- Cheque para trinta dias.\n\n- Em duas vezes.\n\n- Em três vezes.\n\n- Em quatro vezes.\n\n- A partir de cinco vezes.\n\nEntre com sua opção <1 - 6>: ");
            opcao = Int32.Parse(Console.ReadLine());

            if(opcao == 1)
            {
                Console.WriteLine("Desconto de 20%");
            }
            else if(opcao >= 2 && opcao <= 4)
            {
                Console.WriteLine("Mesmo preço a vista");
            }
            else if(opcao == 5)
            {
                Console.WriteLine("Desconto de 3% ao mês");
            }
            else if(opcao == 6)
            {
                Console.WriteLine("Desconto de 5% ao mês");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
