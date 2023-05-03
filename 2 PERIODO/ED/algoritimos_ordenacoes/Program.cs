var vet = new int[] {4,1,3,2,5,7,6,9,8}; 

//OrdenarPorIsercao(vet);
OrdenarPorSelecao(vet);

for(int i = 0; i < vet.Length; i++)
{
    Console.Write($"{vet[i]} ");
}

void Trocar(int[] vet, int i, int j)
{
    var aux = vet[i];
    vet[i] = vet[j];
    vet[j] = aux;
}

void OrdenarPorSelecao(int[] vet)
{
    int indiceMenor;

    for(int pos = 0; pos < vet.Length - 1; pos++)
    {
        indiceMenor = pos;

        for(int i = pos + 1; i < vet.Length; i++)
        {
            if(vet[i] < vet[indiceMenor])
            {
                indiceMenor = i;
            }
        }

        if(pos != indiceMenor)
        {
            Trocar(vet, pos, indiceMenor);
        }
    }
}

void OrdenarPorIsercao(int[] vet)
{
    int pos, aux;

    for(int corte = 0; corte < vet.Length - 1; corte++)
    {
        pos = corte + 1;
        aux = vet[pos];

        while(pos > 0 && vet[pos - 1] > aux)
        {
            vet[pos] = vet[pos - 1];
            pos--;
        }

        vet[pos] = aux;
    }
}