public class FuncionarioHorista : Funcionario
{
    private int _numeroHoras;
    public int NumeroHoras
    {
        get { return _numeroHoras; }
        set { _numeroHoras = value; }
    }

    private double _valorHora;
    public double ValorHora
    {
        get { return _valorHora; }
        set { _valorHora = value; }
    }

    public override double RetornarSalario()
    {
        return NumeroHoras * ValorHora;
    }
}