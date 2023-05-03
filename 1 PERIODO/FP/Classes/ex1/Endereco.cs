using System;

namespace ex1
{
    class Endereco
    {
        public string Logradouro
        {
            get{return logradouro;}
            set{logradouro = value;}    
        }
        public int Numero
        {
            get{return numero;}
            set{numero = value;}    
        }
        public string Cidade
        {
            get{return cidade;}
            set{cidade = value;}    
        }

        private string logradouro;
        private int numero;
        private string cidade;
    }
}
