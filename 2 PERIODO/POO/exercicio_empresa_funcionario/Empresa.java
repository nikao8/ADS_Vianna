
import java.util.ArrayList;

public class Empresa
{
    private  String nome, cnpj;
    //Funcionario[] meusFuncionarios;
    private ArrayList<Funcionario> meusFuncionarios;
    
    
    
    public Empresa(){
       this("",""); 
       //this.nome = "";
       //this.cnpj = "";
       //usFuncionarios = new Funcionario[3];
    }
    public Empresa(String nome, String cnpj){
        this.nome = nome;
        this.cnpj = cnpj;
        meusFuncionarios = new ArrayList<>();
    }
    
    public void setNome(String nome){
        if (nome != null && !nome.equals("") ){
            this.nome = nome;
        }
    }
    public String getNome(){
        return nome;
    }
    
    public void setCNPJ(String cnpj){
        if (cnpj != null && !cnpj.equals("") ){
            this.cnpj = cnpj;
        }
    }
    public String getCNPJ(){
        return cnpj;
    }
        
    public void addFuncionario( Funcionario func){
        meusFuncionarios.add( func );        
    }
        
    public void removeFuncionario( int posicao){
        meusFuncionarios.remove( posicao );        
    }    
    public ArrayList<Funcionario> getMeusFuncionarios(){
        return meusFuncionarios;
    }  
    /*public void setMeusFuncionarios(ArrayList<Funcionario> lista){
        meusFuncionarios = lista;
    }*/
    
    public double salariosPagos(){        
        double soma = 0;
       /* for(Funcionario f :meusFuncionarios){
           if( f != null){
               soma += f.salarioLiquido();
            } 
        }*/
        for(int i = 0; i < meusFuncionarios.size() ; i++ ){
            if( meusFuncionarios.get(i) != null){
               soma += meusFuncionarios.get(i).salarioLiquido();
            }
        }
        
        return soma;
        
    }
    
    
}
