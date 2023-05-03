using System;

namespace ex4
{
    class Program
    {
        // FORMA SIMPLIFICADA NO FINAL, SEM MOSTRAR TODOS OS INDICES.
        const int tamVet = 15;
        static void Main(string[] args)
        {
            int[] valores = new int[tamVet];
            int buscar, contador = 0, j = 0;
            

            for(int i = 0;i < valores.Length; i++)
            {   
                Console.Write("Insira o valor {0} de {1}: ", i+1, tamVet);
                valores[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Insira o valor a ser buscado no vetor: ");
            buscar = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < valores.Length; i++)
            {
                if(buscar == valores[i])
                {
                    contador++;
                }
            }

            int[] indices = new int[contador];

            for(int i = 0; i < valores.Length; i++)
            {
                if(buscar == valores[i])
                {
                    indices[j] = i+1;
                    j++;
                }
            }

            if(contador != 0)
            {
                Console.Write("o valor {0} foi encontrado no vetor {1} vez(s)", buscar, contador);
                
                Console.Write(" nos indices: ");
                for(int i = 0; i< indices.Length; i++)
                {
                    if(i == indices.Length-1)
                    {
                        Console.Write(indices[i]);
                    }
                    else
                    {
                        Console.Write(indices[i] + ",");
                    }              
                }
            }
            else
            {
                Console.WriteLine("o valor {0} não foi encontrado no vetor.", buscar);
            }
        }

        /* // SEGUNDA FORMA, SEM MOSTRAR TODOS OS INDICES:
        const int tamVet = 15;
        static void Main(string[] args)
        {
            int[] valores = new int[tamVet];
            int buscar, contador = 0;
            for(int i = 0;i < valores.Length; i++)
            {   
                Console.Write("Insira o valor {0} de {1}: ", i+1, tamVet);
                valores[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Insira o valor a ser buscado no vetor: ");
            buscar = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < valores.Length; i++)
            {
                if(buscar == valores[i])
                {
                    contador++;
                }
            }

            if(contador != 0)
            {
                Console.WriteLine("o valor {0} foi encontrado no vetor {1} vez(s).", buscar, contador);
            }
            else
            {
                Console.WriteLine("o valor {0} não foi encontrado no vetor.", buscar);
            }
        }
        */
    }
}
