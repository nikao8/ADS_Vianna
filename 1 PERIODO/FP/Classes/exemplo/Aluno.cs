using System;

namespace exemplo
{
    class Aluno
    {
        // Construtor da classe:
        public Aluno(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
        }
        // Construtor vazio, para que tambem seja possivek instanciar um objeto com atributos vazios, exemplo aluno b.
        public Aluno()
        {

        }

        public int Matricula
        {
            get {return matricula;}
            set {matricula = value;}
        }

        public string Nome
        {
            get {return nome;}
            set {nome = value;}
        }

        private int matricula;
        private string nome;
    }
}
