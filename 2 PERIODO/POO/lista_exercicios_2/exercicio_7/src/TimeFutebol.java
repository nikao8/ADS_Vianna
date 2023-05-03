import java.util.ArrayList;

public class TimeFutebol
{
    private String nome;
    private String cidade;
    private String estado;
    private ArrayList<Jogador> jogadores;

    public TimeFutebol(){
        jogadores = new ArrayList<Jogador>();
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    public String getNome(){
        return nome;
    }
     public void setCidade(String cidade){
        this.cidade = cidade;
    }
    public String getCidade(){
        return cidade;
    }
    public void setEstado(String estado){
        this.estado = estado;
    }
    public String getEstado(){
        return estado;
    }

    public ArrayList<Jogador> getJogadores() {
        return jogadores;
    }

    public void addJogador(Jogador j) {
        this.jogadores.add(j);
    }
}
