import java.util.ArrayList;

public class Banco
{
    private String nome;
    private ArrayList<Conta> contas;
    
    public Banco(){
        contas = new ArrayList<Conta>();
    }
    
    public ArrayList<Conta> getContas( ){
        return contas;
    }
    
    public void addConta(Conta c ){
        contas.add(c);
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public String getNome( ){
        return nome;
    }
    
}
