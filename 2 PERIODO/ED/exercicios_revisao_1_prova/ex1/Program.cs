internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] vet = new int[]{35,22,68,15,78,7,74};

        Bubblesort(vet);

        for(int i = 0; i < vet.Length; i++){
            Console.Write(vet[i] + " ");
        }
    }

    static void Bubblesort(int[] vet)
    {
        int j = 0, aux;
        
        while(vet.Length > j++){

            for(int i = 0; i < vet.Length - 1; i++){
               if(vet[i] > vet[i+1])
               {
                    aux = vet[i];
                    vet[i] = vet[i+1];
                    vet[i+1] = aux;
               } 
            }
            //j++;
        }
    }
}