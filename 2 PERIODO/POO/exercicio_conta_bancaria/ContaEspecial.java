
public class ContaEspecial extends Conta
{
    private double limite;
    
    public ContaEspecial(double limite){
       super("",0);  // Vou errar na prova!!!!!!
       this.limite = limite;
   }
   
   @Override
   public void sacar(double valor){
        if (valor > 0 && valor <= (saldo+limite)){
          saldo -= valor;
        }
    }
   
    public void setLimite(double limite){
        this.limite = limite;
    }
    
    public double getLimite( ){
        return limite;
    }
    
}
