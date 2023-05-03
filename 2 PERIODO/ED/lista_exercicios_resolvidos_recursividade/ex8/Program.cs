internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] vet = new int[] {5,15,89,3,74,9};

        Console.WriteLine("O menor valor do vetor é: {0}", Minimo(vet, vet.Length - 1, vet[vet.Length - 1]));
    }

    static int Minimo(int[] vet, int i, int menor)
    {
        if(i < 0)
        {
            return menor;
        }

        if(vet[i] < menor)
        {
            menor = vet[i];
        }

        return Minimo(vet, i-1, menor);
    }


}