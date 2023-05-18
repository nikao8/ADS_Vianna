using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana12_listas_encadeadas
{
    public class ListaEncadeada
    {
        private No primeiro = null;

        public No Primeiro{
            get {
                return primeiro;
            }
        }

        public void AdicionarNoInicio(int valor){
            No novo = new No();
            novo.Valor = valor;

            if(primeiro == null)
            {
                primeiro = novo;
            }
            else
            { 
                novo.Proximo = primeiro;
                primeiro = novo;
            }
        }

        public void AdicionarNoFinal(int valor){
            No novo = new No();
            novo.Valor = valor;

            if(primeiro == null) {
                primeiro = novo;
            }
            else { 
                No aux = primeiro;


                while(aux.Proximo != null){ // ao termino do laço, a variavel aux vai apontar para o ultimo elemento da lista
                    aux = aux.Proximo;
                }

                aux.Proximo = novo;
            }
        }

        public void RemoverInicio(){
            if(primeiro == null){
                throw new Exception("Lista vazia!");
            }

            primeiro = primeiro.Proximo;
        }

        public void RemoverFinal(){
            if(primeiro == null){
                throw new Exception("Lista vazia!");
            }

            if(primeiro.Proximo == null){ // verifica se o proximo é null, ou seja a lista so possui um elemento, assim removemos ele já que é o unico
                primeiro = null;
            }
            else {
                No aux = primeiro;

                while(aux.Proximo.Proximo != null){
                    aux = aux.Proximo;
                }

                aux.Proximo = null;
            }
        }
    }
}