internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[] {9,6,32,1,7,5,8};

        Console.Write("Vetor antes de ordenar: ");
        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        MetodoBubbleSort(vetor);

        Console.Write("\nVetor depois de ordenar: ");
        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }


    static void MetodoBubbleSort(int[] vet)
    {
        for(int i = 1; i < vet.Length; i++)
        {
            for(int j = 0; j < vet.Length - 1; j++)
            {
                if(vet[j] > vet[j + 1])
                {
                    Troca(vet, j);
                }
            }
        }
    }

    static void Troca(int[] vet, int j)
    {
        int aux;
        aux = vet[j];
        vet[j] = vet[j + 1];
        vet[j + 1] = aux;
    }
}