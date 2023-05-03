public class Funcionario {
    private int qtdHorasTrabalhadas;
    private String nome;
    private double salarioHora;
    private int qtdDependentes;

    public Funcionario(){

    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getQtdHorasTrabalhadas() {
        return qtdHorasTrabalhadas;
    }

    public void setQtdHorasTrabalhadas(int qtdHorasTrabalhadas) {
        this.qtdHorasTrabalhadas = qtdHorasTrabalhadas;
    }

    public double getSalarioHora() {
        return salarioHora;
    }

    public void setSalarioHora(double salarioHora) {
        this.salarioHora = salarioHora;
    }

    public int getQtdDependentes() {
        return qtdDependentes;
    }

    public void setQtdDependentes(int qtdDependentes) {
        this.qtdDependentes = qtdDependentes;
    }

    public double calculaSalarioBruto(){
        return (qtdHorasTrabalhadas * salarioHora) + (50 * qtdDependentes);
    }

    public double calculaDescontoINSS(){
        double salarioBruto = calculaSalarioBruto();
        if(salarioBruto <= 1000)
        {
            return salarioBruto * (8.5/100);
        }
        else
        {
            return salarioBruto * (9/100);
        }
    }

    public double calculaIR(){
        double bruto = calculaSalarioBruto();

        if(bruto <= 500)
        {
            return 0;
        }
        else if(bruto > 500 && bruto <= 1000)
        {
            return bruto * (5/100);
        }
        else
        {
            return bruto * (7/100);
        }
    }

    public double calculaSalarioLiquido(){
        return calculaSalarioBruto() - calculaDescontoINSS() - calculaIR();
    }

}
