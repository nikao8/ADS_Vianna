using System;

namespace semana4_soma_recursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[] {40,20,7,80,60,50,10,30,100};
            
            Console.Write("Vetor antes da ordenacao: " );

            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }

            BubbleSort(vet);

            Console.Write("\nVetor depois da ordenacao: " );

            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
        }


        static void Troca(int[] vetor, int atual, int proxima)
        {
            int aux = vetor[atual];
            
            vetor[atual] = vetor[proxima];
            vetor[proxima] = aux;
        }


        static void BubbleSort(int[] vetor)
        {
            int fim = vetor.Length -1;
            int pos = 0; // pos armazena o indice da ultima troca
            bool troca = true;

            while(troca)
            {
                troca = false;

                for(int i = 0; i < fim; i++)
                {
                    if(vetor[i] > vetor[i+1])
                    {
                        Troca(vetor, i, i+1);
                        pos = i;
                        troca = true;
                    }
                }

                fim = pos;
            }
        }
        /*
        static void BubbleSort(int[] vetor)
        {
            int fim = vetor.Length -1, pos; // pos armazena o indice da ultima troca

            do
            {
                pos = -1;

                for(int i = 0; i < fim; i++)
                {
                    if(vetor[i] > vetor[i+1])
                    {
                        Troca(vetor, i, i+1);
                        pos = i;
                    }
                }

                fim = pos;
            } while(fim > 0);
        }
        */
    }
}

