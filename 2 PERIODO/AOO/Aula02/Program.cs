FuncionarioMensalista func1 = new FuncionarioMensalista();
func1.Nome = "João";
func1.Salario = 1234.56;
Console.WriteLine(func1.RetornarSalario());

FuncionarioHorista func2 = new FuncionarioHorista();
func2.Nome = "José";
func2.NumeroHoras = 40;
func2.ValorHora = 50;
Console.WriteLine(func2.RetornarSalario());

Imprimir(func1);
Imprimir(func2);

void Imprimir(Funcionario func)
{
    Console.WriteLine($"{func.Nome}, salário: {func.RetornarSalario()}");
}