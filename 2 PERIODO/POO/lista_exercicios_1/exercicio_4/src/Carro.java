public class Carro {

    private boolean cambio_automatico;
    private boolean vidro_automatico;
    private boolean alarme;
    private boolean teto_solar;
    private boolean kit_multimidia;
    private double potencia_motor;
    private double preco;
    private boolean ar_condicionado;
    private boolean pintura_especial;

    public Carro(){
        this.cambio_automatico = false;
        this.vidro_automatico = false;
        this.alarme = false;
        this.teto_solar = false;
        this.kit_multimidia = false;
        this.preco = 0.0;
        this.pintura_especial = false;
    }

    public double getPreco() {
        return preco;
    }

    public void setPreco(double preco) {
        this.preco = preco;
    }

    public boolean isPintura_especial() {
        return pintura_especial;
    }

    public void setPintura_especial(boolean pintura_especial) {
        this.pintura_especial = pintura_especial;
    }

    public boolean isAr_condicionado() {
        return ar_condicionado;
    }

    public void setAr_condicionado(boolean ar_condicionado) {
        this.ar_condicionado = ar_condicionado;
    }

    public boolean isCambio_automatico() {
        return cambio_automatico;
    }

    public void setCambio_automatico(boolean cambio_automatico) {
        this.cambio_automatico = cambio_automatico;
    }

    public boolean isVidro_automatico() {
        return vidro_automatico;
    }

    public void setVidro_automatico(boolean vidro_automatico) {
        this.vidro_automatico = vidro_automatico;
    }

    public boolean isAlarme() {
        return alarme;
    }

    public void setAlarme(boolean alarme) {
        this.alarme = alarme;
    }

    public boolean isTeto_solar() {
        return teto_solar;
    }

    public void setTeto_solar(boolean teto_solar) {
        this.teto_solar = teto_solar;
    }

    public boolean isKit_multimidia() {
        return kit_multimidia;
    }

    public void setKit_multimidia(boolean kit_multimidia) {
        this.kit_multimidia = kit_multimidia;
    }

    public double getPotencia_motor() {
        return potencia_motor;
    }

    public void setPotencia_motor(double potencia_motor) {
        this.potencia_motor = potencia_motor;
    }

    private void calculaIPI(){
        if(potencia_motor == 1.0){
            preco += preco * 0.1;
        }
        else{
            preco += preco * 0.2;
        }
    }

    private void somatizaAr(){
        if(ar_condicionado)
        {
            preco += 3000;
        }
    }

    private void somatizaCambio(){
        if(cambio_automatico)
        {
            preco += 5000;
        }
    }

    private void somatizaPintura(){
        if(pintura_especial)
        {
            preco += 2500;
        }
    }

    private void somatizaAlarme(){
        if(alarme)
        {
            preco += 800;
        }
    }

    private void somatizaTeto(){
        if(teto_solar)
        {
            preco += 4000;
        }
    }

    private void somatizaKit(){
        if(kit_multimidia)
        {
            preco += 1800;
        }
    }

    public void calculaPrecoFinal(){
        somatizaAr();
        somatizaAlarme();
        somatizaCambio();
        somatizaKit();
        somatizaTeto();
        somatizaPintura();
        calculaIPI();
    }
}
