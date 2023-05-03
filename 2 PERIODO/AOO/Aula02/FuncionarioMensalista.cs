public class FuncionarioMensalista : Funcionario
{
    public double Salario
    {
        get { return _salario; }
        set { _salario = value; }
    }

    public override double RetornarSalario()
    {
        return _salario;
    }
    
    private double _salario;
}
