public class Jogador {
    private int simbolo;
    private boolean vencedor;
    public Jogador(int simbolo){
        this.vencedor = false;
        this.simbolo = simbolo;
    }

    public boolean isVencedor() {
        return vencedor;
    }

    public void setVencedor(boolean vencedor) {
        this.vencedor = vencedor;
    }

    public int getSimbolo() {
        return simbolo;
    }
}
