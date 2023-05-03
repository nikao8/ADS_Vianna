internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Insira o valor do montante da aposentadoria: ");
        double montante = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira o valor do saque por mês: ");
        double saque = Convert.ToDouble(Console.ReadLine());

        CalculaMontante(montante,saque);
    }

    static void CalculaMontante(double montante, double saque, int contador = 0)
    {

        montante -= saque;
        montante -= montante * (0.55 / 100) ;
        
        if(montante <= 0)
        {
            Console.WriteLine("\nVocê vai conseguir fazer a retirada em {0} meses.", contador);
            return;// contador;
        }

        contador++;

        Console.WriteLine("Valor do montante no mês {0}: {1:N2}", contador, montante);

        CalculaMontante(montante, saque, contador);
    }
}