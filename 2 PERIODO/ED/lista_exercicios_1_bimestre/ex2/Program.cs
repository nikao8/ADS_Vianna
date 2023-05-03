internal class Program
{
    private static void Main(string[] args)
    {
        int[] vet = new int[]{8,-3,-2,5,3,-5,3};
        Console.WriteLine("A quantidade de numeros negativos encontrado é: {0}", PercorreVetor(vet));

        Console.WriteLine("O vetor é: ");
        for(int i = 0; i < vet.Length; i++)
        {
            Console.Write(vet[i] + " ");
        }
    }
    /* // utilizando a função empacotadora
    static int PercorreVetor(int[] vet)
    {
        return PercorreVetor(vet,0,0);
    }
    */
    static int PercorreVetor(int[] vet, int i=0, int contador=0 /*não seria necessário o valor padrão caso usasse a função empacotadora*/)
    {
        if(i >= vet.Length)
        {
            return contador;
        }

        if(vet[i] < 0)
        {
            vet[i] = vet[i] * -1;
            contador++;
        }

        return PercorreVetor(vet, i+1, contador);
    }

 
}