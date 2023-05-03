public class Emprestimo {
    private double valorTotalEmprestimo;
    private double jurosMensal;
    private int qtdMeses;

    public Emprestimo(){}

    public double getValorTotalEmprestimo() {
        return valorTotalEmprestimo;
    }

    public void setValorTotalEmprestimo(double valorTotalEmprestimo) {
        this.valorTotalEmprestimo = valorTotalEmprestimo;
    }

    public double getJurosMensal() {
        return jurosMensal;
    }

    public void setJurosMensal(double jurosMensal) {
        this.jurosMensal = jurosMensal;
    }

    public int getQtdMeses() {
        return qtdMeses;
    }

    public void setQtdMeses(int qtdMeses) {
        this.qtdMeses = qtdMeses;
    }

    public double valorMensalidade()
    {
        return (valorTotalEmprestimo + (valorTotalEmprestimo * (jurosMensal/100))) / qtdMeses;
    }

    public double valorPagoFinal()
    {
        return valorMensalidade() * qtdMeses;
    }

    public double valorPagoJuros()
    {
        return valorPagoFinal() - valorTotalEmprestimo;
    }
}
