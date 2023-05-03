public class Horista extends Empregado{
    private double precoHora;
    private double HorasTrabalhadas;

    @Override
    public double vencimento(){
        return 0.3;
    }

    public double getPrecoHora() {
        return precoHora;
    }

    public void setPrecoHora(double precoHora) {
        this.precoHora = precoHora;
    }

    public double getHorasTrabalhadas() {
        return HorasTrabalhadas;
    }

    public void setHorasTrabalhadas(double horasTrabalhadas) {
        HorasTrabalhadas = horasTrabalhadas;
    }
}
