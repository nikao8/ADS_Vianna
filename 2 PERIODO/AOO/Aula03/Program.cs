using Aula03;

internal class Program
{
    private static void Main(string[] args)
    {
        var funcionarios = new Funcionario[2];
        funcionarios[0] = new FuncionarioMensalista
        {
            Nome = "Ana",
            Email = "ana@email.com",
            ValorMensal = 1234.56
        };
       
        funcionarios[1] = new FuncionarioHorista
        {
            Nome = "Bruno",
            Email = "bruno@email.com",
            QtdeHoras = 20,
            ValorHora = 123.45
        };

        var totalFolhaPagto = 0.0;

        
        for(int i = 0; i < funcionarios.Length; i++)
        {
            totalFolhaPagto += funcionarios[i].GetSalario();
        }
        

        Console.WriteLine($"Total da folha de pagamento: {totalFolhaPagto:C2}");
    }
}