import java.util.Scanner;

public class Principal
{
    
    public static void main(String args[]){
        
        Scanner le = new Scanner(System.in);
        
        System.out.println("Informe o tipo de Conta (P)oupança ou (C)onta Especial?");
        String resp = le.next();
        if (resp.equals("P")){
            
            Poupanca p = new Poupanca();
            
            System.out.println("Numero: ");
            p.setNumero( le.next() );            
            System.out.println("Deposito Inicial: ");
            p.depositar( le.nextDouble() );  
            
        }else{
            System.out.println("Informe o Limite de Credito: ");
            ContaEspecial ce = new ContaEspecial( le.nextDouble() );
            System.out.println("Numero: ");
            ce.setNumero( le.next() );            
            System.out.println("Deposito Inicial: ");
            ce.depositar( le.nextDouble() );  
        }
        
        //Saldo?????
        //System.out.println("Saldo "+p.getSaldo() );
        
        /*
         Conta c; 
         
        //c = new ContaEspecial(1000);
        c = new Poupanca();
        
        c.depositar(500);
        
        System.out.println("Saldo "+c.getSaldo() );
        
        ((Poupanca)c).rendimento();
        
        System.out.println("Saldo "+c.getSaldo() );        
        */
        
    }
    
}
