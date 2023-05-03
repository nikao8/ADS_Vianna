public class Competidor {

    private Kart[] karts;
    private String nome;
    private int pontuacao;

    public Competidor(String nome, int lugar){
        karts = new Kart[2];

        if(lugar == 1){
            pontuacao = 25;
        } else if (lugar == 2) {
            pontuacao = 15;
        } else if (lugar == 3) {
            pontuacao = 10;
        } else if (lugar == 4) {
            pontuacao = 7;
        } else if (lugar == 5) {
            pontuacao = 5;
        } else if (lugar == 6) {
            pontuacao = 1;
        } else {
            pontuacao = 0;
        }

        this.nome = nome;

        for(int i = 0; i < 2 ; i++){
            if(i == 0){
                karts[i] = new Kart(true);
            }
            karts[i] = new Kart(false);
        }
    }


    public Kart[] getKarts() {
        return karts;
    }

    public void setKarts(Kart[] karts) {
        this.karts = karts;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getPontuacao() {
        return pontuacao;
    }

    public void setPontuacao(int pontuacao) {
        this.pontuacao = pontuacao;
    }

    public void trocaKart(){
        karts[0].setPrincipal(false);
        karts[1].setPrincipal(true);
        this.pontuacao -= 5;
    }
}
