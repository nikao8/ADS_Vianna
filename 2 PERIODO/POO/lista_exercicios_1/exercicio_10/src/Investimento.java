public class Investimento {
    private int mes;
    private double taxaJuros;
    private double investimento;
    private double investimentoAtualizado;

    public Investimento(){
        this.mes = 0;
    }

    public int getMes() {
        return mes;
    }

    public void setMes() {
        this.mes++;
        calculaInvestimento();
    }

    public double getTaxaJuros() {
        return taxaJuros;
    }

    public void setTaxaJuros(double taxaJuros) {
        this.taxaJuros = taxaJuros;
    }

    public double getInvestimento() {
        return investimento;
    }

    public void setInvestimento(double investimento) {
        this.investimento = investimento;
        this.investimentoAtualizado = investimento;
    }

    private double calculaTaxaJuros(double valorInvestimentoAtual){
        return valorInvestimentoAtual * (taxaJuros/100);
    }
    private void calculaInvestimento(){
        investimentoAtualizado += calculaTaxaJuros(investimentoAtualizado) + investimento;
    }

    public double exibeResultadoInvestimento(){
        return investimentoAtualizado - investimento;
    }
}
