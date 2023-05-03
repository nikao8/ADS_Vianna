
public class Conta
{
    private String numero;
    protected double saldo;
    private Cliente correntista;
    private Banco banco;
    
    public Conta(String numero, double saldo){
        this.numero = numero;
        this.saldo = saldo;
    }
    
    public void sacar(double valor){
        if (valor > 0 && valor <= saldo){
          saldo -= valor;
        }
    }
    
    public void depositar(double valor){
        if (valor > 0 ){
          saldo += valor;
        }
    }
    
    
    public void setNumero(String numero){
        this.numero = numero;
    }
    
    public String getNumero( ){
        return numero;
    }
    
    public double getSaldo( ){
        return saldo;
    }
    
    
    public void setCorrentista(Cliente correntista){
        this.correntista = correntista;
    }
    
    public Cliente getCorrentista( ){
        return correntista;
    }    
    
    public void setBanco(Banco banco){
        this.banco = banco;
    }
    
    public Banco getBanco( ){
        return banco;
    }
    
    
    
    
    
}
