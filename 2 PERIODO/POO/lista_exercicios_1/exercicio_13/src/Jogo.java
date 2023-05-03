public class Jogo {
    private Tabuleiro tabuleiro;
    private Jogador jogador1;
    private Jogador jogador2;

    public Jogo(){
        tabuleiro = new Tabuleiro();
        jogador1 = new Jogador(1);
        jogador2 = new Jogador(-1);
    }

    private int verificaResultado(){
        if(tabuleiro.verificaLinha() == 1){
            jogador1.setVencedor(true);
            return 1;
        }
        if(tabuleiro.verificaColuna() == 1){
            jogador1.setVencedor(true);
            return 1;
        }
        if(tabuleiro.verificaDiagonal() == 1){
            jogador1.setVencedor(true);
            return 1;
        }

        if(tabuleiro.verificaLinha() == -1){
            jogador2.setVencedor(true);
            return -1;
        }
        if(tabuleiro.verificaColuna() == -1){
            jogador2.setVencedor(true);
            return -1;
        }
        if(tabuleiro.verificaDiagonal() == -1){
            jogador2.setVencedor(true);
            return -1;
        }

        return 0;
    }

    public int verificaTermino(){
        if(tabuleiro.getnJogada() >= 9 && verificaResultado() == 0){
            return 2;
        }
        return verificaResultado();
    }

    public Tabuleiro getTabuleiro() {
        return tabuleiro;
    }

    public Jogador getJogador1() {
        return jogador1;
    }

    public void setJogador1(Jogador jogador1) {
        this.jogador1 = jogador1;
    }

    public Jogador getJogador2() {
        return jogador2;
    }

    public void setJogador2(Jogador jogador2) {
        this.jogador2 = jogador2;
    }

}
