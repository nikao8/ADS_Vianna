internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] vet = new int[]{35,22,68,15,78,7,74};

        Selecao(vet);

        for(int i = 0; i < vet.Length; i++){
            Console.Write(vet[i] + " ");
        }
    }

    static void Selecao(int[] vet){

        int menor, aux;

        for(int i = 0; i < vet.Length - 1; i++)
        {
            menor = i;

            for(int j = i; j < vet.Length; j++){
                if(vet[j] < vet[menor]){
                    menor = j; 
                }
            }

            aux = vet[menor];
            vet[menor] = vet[i];
            vet[i] = aux;
        }

    }
}