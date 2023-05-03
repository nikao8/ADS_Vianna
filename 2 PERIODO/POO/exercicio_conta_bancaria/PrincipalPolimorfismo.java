import java.util.Scanner;

public class PrincipalPolimorfismo
{
    public static void main(String args[]){
        
        Scanner le = new Scanner(System.in);
        
        System.out.println("Informe o tipo de Conta (P)oupança ou (C)onta Especial?");
        String resp = le.next();
        
        Conta c = (resp.equals("P"))?new Poupanca():new ContaEspecial(0);
        /*
        if (resp.equals("P")){
             c = new Poupanca();
        }else{
            c = new ContaEspecial(0);
        }*/
        if ( c instanceof ContaEspecial){
            System.out.println("Informe o Limite de Credito: ");
            ((ContaEspecial)c).setLimite( le.nextDouble() );
        }
        System.out.println("Numero: ");
        c.setNumero( le.next() );            
        System.out.println("Deposito Inicial: ");
        c.depositar( le.nextDouble() );  
        
        
    }
}
