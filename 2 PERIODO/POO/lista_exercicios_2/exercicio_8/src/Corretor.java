import java.util.ArrayList;
public class Corretor
{
    private String nome;
    private int idade;
    private ArrayList<Imovel>imoveis;
    public Corretor(){
        this.imoveis=new ArrayList<Imovel>();
    }
    
    public double Comissao(double porcentagem, int i){
        double aux =0;

        aux = imoveis.get(i).getPreco() * porcentagem;

        return aux;
    }
    
    public void setNome(String nome){
        this.nome=nome;
    }
    public void setIdade(int idade){
        this.idade=idade;
    }
    public void addImovel(Imovel i){
        imoveis.add(i);
    }
    public void removeImovel(Imovel i){
        imoveis.remove(i);
    }
    public ArrayList<Imovel>getImoveis(){
        return imoveis;
    }
}
