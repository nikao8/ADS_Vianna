using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulado_ed
{
    public class Pilha
    {
        private No? topo = null; 
        //lembrar do exemplo da pilha de prato, quem entra por último sai primeiro
        public void Empilhar(int valor)
        {
            //var novoNo = new No { Valor = valor };

            //if (topo == null)
            //    topo = novoNo;
            //else
            //{
            //    novoNo.Proximo = topo;
            //    topo = novoNo;
            //}isso é a mesma coisa de:

            topo = new No { Valor = valor, Proximo = topo }; //isso não tem problema pq o próximo pode receber nulo
        }

        public void Desempilhar()
        {
            if (topo == null)
                throw new Exception("Não é possível desempilhar um elemento de uma pilha vazia.");

            topo = topo.Proximo;

        }
        public int? GetTopo()
        {
            //return topo == null ? null : topo.Valor; 
            //tb poderia ser:
            return topo?.Valor; //se o too for null, ele retorna null, senão ele retona o valor. isso se chama "operadores condicionais nulos"

        }



    }
}