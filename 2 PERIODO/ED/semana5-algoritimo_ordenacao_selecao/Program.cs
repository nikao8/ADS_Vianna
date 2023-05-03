internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] vet = new int[] {40,20,7,80,60,50,10,30,100};
        
        Console.Write("Vetor antes da ordenacao: " );

        for(int i = 0; i < vet.Length; i++)
        {
            Console.Write(vet[i] + " ");
        }

        Selecao(vet);

        Console.Write("\nVetor depois da ordenacao: " );

        for(int i = 0; i < vet.Length; i++)
        {
            Console.Write(vet[i] + " ");
        }
    }

    static void Selecao(int[] vetor)
    {
        for(int i = 0; i < vetor.Length-1; i++)
        {
            int indMenor = i;
            //localiza o indice indMenor do menor elemnto
            // na parte não ordenada do vetor
            for(int j= i+1; j < vetor.Length; j++)
            {
                if(vetor[j] < vetor[indMenor])
                {
                    indMenor = j;
                }
            }

            if(i != indMenor) //troca o item i pelo item indMenor
            {
                Troca(vetor, i, indMenor);
            }
        }   
    }

    static void Troca(int[] vetor, int i, int indMenor)
    {
        int aux = vetor[i];
            
        vetor[i] = vetor[indMenor];
        vetor[indMenor] = aux;
    }
}