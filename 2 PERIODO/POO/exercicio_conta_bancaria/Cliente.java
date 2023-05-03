import java.util.ArrayList;

public class Cliente
{
    private String nome, cpf;
    private double salario;
    private ArrayList<Conta> minhasContas;
    
    public Cliente(){
        minhasContas = new ArrayList<Conta>();
    }
    
    public ArrayList<Conta> getContas( ){
        return minhasContas;
    }
    
    public void addConta(Conta c ){
        minhasContas.add(c);
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public String getNome( ){
        return nome;
    }
    
    public void setCpf(String cpf){
        this.cpf = cpf;
    }
    
    public String getCpf( ){
        return cpf;
    }
    
    public void setSalario(double salario){
        this.salario = salario;
    }
    
    public double getSalario( ){
        return salario;
    }
}
