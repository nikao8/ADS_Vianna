using System;
using simulado_ed;
/* 

Explique o que é uma pilha e o que é uma fila e qual a diferença entre essas duas
estruturas de dados.

R: Uma pilha é uma estrutura de dados em que os elementos são organizados seguindo o princípio LIFO (Last-In, First-Out),
o que significa que o último elemento inserido é o primeiro a ser removido.
Você pode imaginar uma pilha de pratos, onde você adiciona pratos no topo e retira pratos também do topo.
As operações fundamentais em uma pilha são a inserção de um elemento (conhecida como "push") e a remoção de um elemento (conhecida como "pop"),
que ocorrem apenas no topo da pilha.

Por outro lado, uma fila é uma estrutura de dados em que os elementos são organizados seguindo o princípio FIFO (First-In, First-Out),
o que significa que o primeiro elemento inserido é o primeiro a ser removido. Você pode pensar em uma fila de pessoas esperando em uma fila,
onde a primeira pessoa que entra é a primeira a sair. As operações fundamentais em uma fila são a inserção de um elemento (também conhecida como "enqueue")
e a remoção de um elemento (conhecida como "dequeue"), que ocorrem nas extremidades opostas da fila.

A diferença principal entre uma pilha e uma fila está na forma como os elementos são inseridos e removidos. Enquanto em uma pilha você pode adicionar e remover elementos apenas do topo, em uma fila você pode adicionar elementos em uma extremidade (final da fila) e remover elementos na outra extremidade (início da fila). Isso resulta em comportamentos diferentes: a pilha segue uma ordem inversa à ordem de inserção, pois o último elemento inserido é o primeiro a ser removido, enquanto a fila mantém a ordem de inserção, onde o primeiro elemento inserido é o primeiro a ser removido.

Em resumo, a pilha e a fila são duas estruturas de dados diferentes que organizam e armazenam elementos de maneiras distintas. A pilha segue o princípio LIFO,
enquanto a fila segue o princípio FIFO.

*/

namespace simulado_ed {
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            Fila lista = new Fila();

            int n;

            Console.WriteLine("Informe o N:");

            n = Convert.ToInt32(Console.ReadLine());

            while(n != 0){
                lista.AdicionarFinal(n);

                Console.WriteLine("Informe o proximo valor de N:");

                n = Convert.ToInt32(Console.ReadLine());
            }

            Imprimir(lista);

            ImprimirInverso(lista);

            while(lista.Primeiro != null) {
                lista.RemoverNoInicio();
            }

            Imprimir(lista);
        }

        private static void Imprimir(Fila lista)
        {
            No aux = lista.Primeiro;

            Console.Write("Lista: ");

            while(aux != null){
                Console.Write("{0,3}", aux.Valor);

                aux = aux.Proximo;
            }

            Console.WriteLine();
        }

        private static void ImprimirInverso(Fila lista){
            No aux = lista.Ultimo;

            
            while(aux != null){
                Console.Write("{0,3}", aux.Valor);

                aux = aux.Anterior;
            }

            Console.WriteLine();
        }

    }
}
