
public class Poupanca extends Conta
{
   public Poupanca(){
       super("",0);  // Vou errar na prova!!!!!!
   }
        
    public void rendimento(){
         //depositar( getSaldo() * 0.002); 
         saldo *= 1.002;
    }
    
}
