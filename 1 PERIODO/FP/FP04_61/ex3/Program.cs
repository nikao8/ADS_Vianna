using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            char sexo;

            Console.Write("CALCULO DE PESO IDEAL:\n\nInsira sua altura utilizando notação de '.': ");
            altura = Double.Parse(Console.ReadLine());
            
            Console.Write("Insira seu sexo (m ou f): ");
            sexo = Char.Parse(Console.ReadLine());

            double pi = 0;
            if(sexo == 'm' || sexo == 'M')
            {
                pi = (72.7*altura)-58;
            }
            else if(sexo == 'f' || sexo == 'F')
            {
                pi = (62.1*altura)-44.7;
            }
            else
            {
                Console.WriteLine("Sexo inválido.");
                return;
            }

            Console.WriteLine("O seu peso ideal é de: {0}", pi);
        }
    }
}
