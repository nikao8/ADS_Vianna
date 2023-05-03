using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03
{
    public abstract class Funcionario // classe abstrata nao pode ser instanciada
    {
        private string _nome = "";        
        private string email = "";

        public string Nome
        {
            get {return _nome;}
            set {_nome = value;}
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        // virtual sinaliza que o metodo pode ser sobreposto em outra classe com o override
        // abstract não possui implementação, quando há um metodo abstrato a classe tbm tem que ser abstrata
        public abstract double GetSalario();
        //{
            //return 0;
        //}

    }
}