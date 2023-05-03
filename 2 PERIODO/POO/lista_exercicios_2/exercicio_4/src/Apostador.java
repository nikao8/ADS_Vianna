import java.util.ArrayList;

public class Apostador {
    private ArrayList<Cartao> cartoes;
    private String nome;

    public Apostador(){
        this.cartoes = new ArrayList<Cartao>();
    }

    // METODOS GET E SET


    public ArrayList<Cartao> getCartoes() {
        return cartoes;
    }

    public void addCartao(Cartao c) {
        this.cartoes.add(c);
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }
}
