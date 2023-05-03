using System;

namespace ex1
{
    class Hotel
    {
        public Hotel(){} // construtor vazio

        public string Nome{
            get{return nome;}
            set{nome = value;}
        }

        public int Categoria{
            get{return categoria;}
            set{categoria = value;}
        }

        public Endereco Endereco
        {
            get{return endereco;}
            set{endereco = value;}
        }

        private string nome;
        private int categoria;
        private Endereco endereco;
    }
}
