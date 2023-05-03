using System;

namespace ex8
{
    class Program
    {
        const int tamVet = 13;
        static void Main(string[] args)
        {
            int[] g = new int[tamVet];
            int[] r = new int[tamVet];
            int acertos = 0;

            Console.WriteLine("Insira os valores sorteados: SOMENTE OS VALORES 1,2 OU 3!");
            for(int i = 0; i < g.Length; i++)
            {
                Console.Write("Valor {0} de {1}: ", i+1, g.Length);
                g[i] = Int32.Parse(Console.ReadLine());

                if(g[i] < 0 || g[i] > 2)
                {
                    Console.WriteLine("Erro, digito menor que 0 ou maior que 2.");
                    return;
                }
            }

            for(int i = 0; i < tamVet; i++)
            {
                Console.WriteLine("\n[APOSTADOR {0}:]", i+1);
                for (int j = 0;j < r.Length; j++)
                {
                    Console.Write("Aposta {1} de {2}: ", i+1, j+1, r.Length);
                    r[j] = Int32.Parse(Console.ReadLine());

                    if(r[j] < 0 || r[j] > 2)
                    {
                        Console.WriteLine("Erro, digito menor que 0 ou maior que 2.");
                        return;
                    }

                    if(r[j] == g[j])
                    {
                        acertos++;
                    }
                }
                Console.WriteLine("\nApostador {0} obteve {1} acertos!", i+1, acertos);
                acertos = 0;
            }

        }
    }
}
