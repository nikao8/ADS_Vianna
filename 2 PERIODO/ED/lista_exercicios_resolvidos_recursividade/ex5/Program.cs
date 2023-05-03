internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira o numero para descobrir seu fatorial: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fatorial de {0} é: {1}", numero, Fatorial(numero));
    }

    static int Fatorial(int num)
    {
        if(num == 0)
        {
            return 1;
        }
        else
        {
            return num * Fatorial(num - 1);
        }
    }
}