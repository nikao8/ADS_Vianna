internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] vet = new int[]{35,22,68,15,78,7,74};

        Insercao(vet);

        for(int i = 0; i < vet.Length; i++){
            Console.Write(vet[i] + " ");
        }    
    }

    static void Insercao(int [] vet){
        int aux, j;
        for(int i = 1; i < vet.Length; i++){
            aux = vet[i];
            j = i;
            while(j > 0 && aux < vet[j - 1]){
                vet[j] = vet[j - 1];
                j--;
            }
            vet[j] = aux;
        }
    }
}