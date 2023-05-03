public class Kart {
    private Competidor competidor;
    private double motor;
    private String pneu;

    private boolean principal;

    public Kart(boolean principal){
        this.principal = principal;
    }

    public Competidor getCompetidor() {
        return competidor;
    }

    public void setCompetidor(Competidor competidor) {
        this.competidor = competidor;
    }

    public double getMotor() {
        return motor;
    }

    public void setMotor(double motor) {
        this.motor = motor;
    }

    public String getPneu() {
        return pneu;
    }

    public void setPneu(String pneu) {
        this.pneu = pneu;
    }

    public boolean isPrincipal() {
        return principal;
    }

    public void setPrincipal(boolean principal) {
        this.principal = principal;
    }
}
