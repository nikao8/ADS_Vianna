internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Insira um numero: ");
        int n = Convert.ToInt32(Console.ReadLine());

        ImprimeDivisiveisDoisTres(n);
    }

    static void ImprimeDivisiveisDoisTres(int n)
    {
        if(n <= 0)
        {
            return;
        }

        if(n % 2 == 0 && n % 3 == 0)
        {
            Console.Write(n + " ");
        }
   
        ImprimeDivisiveisDoisTres(n-1);

    }
}