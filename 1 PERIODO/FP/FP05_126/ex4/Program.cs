using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int matricula = 0;
            double nota;
            double notaMaior = 0;
            double media=0;
            
            while(matricula >= 0)
            {
                Console.Write("Insira a sua matricula: ");
                matricula = Int32.Parse(Console.ReadLine());

                if(matricula < 0)
                {
                    return;
                }

                for(int i=0; i<3; i++)
                {
                    Console.Write("Insira sua {0} nota: ", i+1);
                    nota = Double.Parse(Console.ReadLine());

                    if(nota > notaMaior)
                    {
                        notaMaior = nota;
                    }
                   
                    media = media + nota * 3;
                }
                
                media = (media + (notaMaior*4) - (notaMaior*3))/10;
                Console.WriteLine("A media ponderada é de {0} e a maior nota foi: {1}", media,notaMaior);

                if(media >= 5)
                {
                    Console.WriteLine("\nVOCÊ FOI APROVADO!\n");
                }
                else
                {
                    Console.WriteLine("\nVOCÊ FOI REPROVADO!\n");
                }
            }
        }
    }
}
