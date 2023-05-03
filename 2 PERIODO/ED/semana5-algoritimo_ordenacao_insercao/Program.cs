using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] vet = new int[] {40,20,7,80,60,50,10,30,100};
        
        Console.Write("Vetor antes da ordenacao: " );

        for(int i = 0; i < vet.Length; i++)
        {
            Console.Write(vet[i] + " ");
        }

        Insercao(vet);

        Console.Write("\nVetor depois da ordenacao: " );

        for(int i = 0; i < vet.Length; i++)
        {
            Console.Write(vet[i] + " ");
        }
    }

    static void Insercao(int[] vetor)
    {
        /*
            Primeira execução:
            temos o vetor {40,20,7,80,60,50,10,30,100}:

            iniciamos o for com i = 1, para que comece comparando a segunda posição(20) com a primeira(40);
            chave recebe o valor do item a ser ordenado, ou seja, chave = vetor[i], logo chave = 20;
            j recebe o valor de i-1, logo j = 0, ou seja, uma posição anterior para a comparação

            após isso, é feito um while que tem considição: enquanto j >= 0  && chave < vetor[j], ou seja enquanto o indice j está dentro do vetor e chave
            for menor que o indice anterior a ela(40) é feito a troca de um com o outro, jogando o maior valor para a direita.

            decrementamos j, apos decrementar o j na primeira execução j tem o valor de -1(fora do vetor), ou seja o valor 20 ja chegou no limite do vetor
            então a execução sai do loop while e executa a linha vetor[j+1] = chave, ou seja vetor[0] (40) = 20
            
            entao na primeira interação do for tinhamos:
                começo :{40,20,7,80,60,50,10,30,100}
                apos entrar no while: {40,40,7,80,60,50,10,30,100}
                ao sair do while e terminar a primeira iteração do for: {20,40,7,80,60,50,10,30,100}
        */
        
        // a parte ordenada está entre 0 e i
        for(int i = 1; i < vetor.Length; i++)
        {
            // valor a ser inserido na parte ordenada
            int chave = vetor[i];
            int j = i-1;

            // localiza a posição j de Chave na parte ordenada
            while(j >= 0 && chave < vetor[j])
            {
                vetor[j+1] = vetor[j];
                j--;
            }

            vetor[j+1] = chave;
        }
    }
}