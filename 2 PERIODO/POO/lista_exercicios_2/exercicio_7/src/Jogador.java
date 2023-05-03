public class Jogador extends Atleta
{
    private int numero;
    private int posicao;

    public Jogador(){
        super("",0);
    }
    public void setNumero(int numero){
        this.numero = numero;
    }
    public int getNumero(){
        return numero;
    }
    public void setPosicao(int posicao){
        this.posicao = posicao;
    }
    public int getPosicao(){
        return posicao;
    }    
}
