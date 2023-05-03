using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel[] hoteis = new Hotel[5];
            int categoria;

            LeHoteis(hoteis);

            Console.Write("Informe a categoria de hotel a ser buscada: ");
            categoria = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoteis disponiveis na categoria {0} estrelas: ", categoria);
            for(int i = 0 ; i < hoteis.Length; i++)
            {
                if(hoteis[i].Categoria == categoria)
                {
                    Console.WriteLine(hoteis[i].Nome);
                }
            }

            Console.ReadKey();
        }

        static void LeHoteis(Hotel[] hoteis)
        {
            for(int i = 0; i < hoteis.Length; i++)
            {
                Console.WriteLine("Hotel {0} de {1}: ", i+1, hoteis.Length);
                hoteis[i] = RetornarHotel();
            }
        }

        static Hotel RetornarHotel()
        {
            Hotel objeto = new Hotel();
            
            Console.Write("Nome: ");
            objeto.Nome = Console.ReadLine();

            Console.Write("Categoria: ");
            objeto.Categoria = Convert.ToInt32(Console.ReadLine());

            objeto.Endereco = RetornaEndereco();
            return objeto;
        }

        static Endereco RetornaEndereco()
        {
            Endereco objeto = new Endereco();

            Console.Write("Logradouro: ");
            objeto.Logradouro = Console.ReadLine();

            Console.Write("Numero: ");
            objeto.Numero = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Cidade: ");
            objeto.Cidade = Console.ReadLine();

            return objeto;
        }
    }    
}
