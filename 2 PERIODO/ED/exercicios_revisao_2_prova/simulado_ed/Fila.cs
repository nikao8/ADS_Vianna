using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulado_ed
{
    public class Fila
    {
        private No? primeiro = null;

        public No Primeiro {
            get {
                return this.primeiro;
            }
        }

        private No? ultimo = null;

        public No Ultimo {
            get {
                return this.ultimo;
            }
        }

        private int tamanho = 0;

        public int Tamanho {
            get {
                return tamanho;                
            }
        }

        public void AdicionarFinal(int valor){

            var novoNo = new No();
            novoNo.Valor = valor;
            
            if (ultimo == null)
                primeiro = ultimo = novoNo;
            else
            {
                novoNo.Anterior = ultimo;
                ultimo.Proximo = novoNo;
                ultimo = novoNo;
            }

            tamanho++;
        }

        public void RemoverNoInicio(){
            var ultimo = primeiro;

            if(ultimo == null) {
                throw new Exception("Lista vazia");
            }

            // 1,2,3,4
            if(primeiro == null){
                primeiro = ultimo = null;
            }
            else {

                if(primeiro.Proximo != null){
                    primeiro.Proximo.Anterior = null;
                }
  
                primeiro = primeiro.Proximo;
                
            }

            tamanho--;
        }
    }
}