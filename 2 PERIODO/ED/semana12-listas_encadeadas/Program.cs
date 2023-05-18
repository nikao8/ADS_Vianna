using System;

namespace semana12_listas_encadeadas{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ListaEncadeada lista = new ListaEncadeada();

            lista.AdicionarNoInicio(1);
            lista.AdicionarNoInicio(2);
            lista.AdicionarNoFinal(3);

            Imprimir(lista);

            lista.RemoverInicio();
            Imprimir(lista);

            lista.RemoverFinal();
            Imprimir(lista);
            
            Console.ReadKey();
        }
    }

    private static void Imprimir(ListaEncadeada lista){
        No aux = lista.Primeiro;

        Console.Write("Lista: ");

        while(aux != null){
            Console.Write("{0,3}", aux.Valor);

            aux = aux.Proximo;
        }

        Console.WriteLine();
    }
}
