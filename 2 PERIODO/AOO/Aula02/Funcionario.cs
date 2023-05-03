public abstract class Funcionario
{
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
    
    public DateTime DataNascimento
    {
        get { return _dataNascimento; }
        set { _dataNascimento = value; }
    }

    public abstract double RetornarSalario();

    private string _nome = "";
    private DateTime _dataNascimento;
}
