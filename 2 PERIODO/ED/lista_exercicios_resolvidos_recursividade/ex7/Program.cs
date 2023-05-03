internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insira uma posição para descobrir seu numero na sequencia de fibonacci: ");
        int posicao = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A posição numero {0} na sequencia de fibonacci é: {1}",posicao ,Fibonacci(posicao));
    }

    static int Fibonacci(int posicao)
    {   
        if(posicao <= 1)
        {
            return posicao;
        }
        else
        {
            return Fibonacci(posicao - 1) + Fibonacci(posicao - 2);
        }
    }
}