import java.util.Scanner;
import java.util.ArrayList;

public class PrincipalFinal
{    
    public static void main(String args[]){
     
        Scanner le = new Scanner(System.in);
        Banco banco = new Banco();
        ArrayList<Cliente> clientes = new ArrayList<>();
        System.out.println("# Informe o nome do Banco:");
        banco.setNome( le.nextLine() );
        
        while(true){
            
            int escolha = montaMenu( le );
            
            if(escolha == 5){
                break;
            } else if(escolha == 1){
                clientes.add( cadastraCliente() );
            } else if(escolha == 2){
                cadastraConta(clientes, banco);
            }
        
        }               
        
    }
    
    public static void cadastraConta(ArrayList<Cliente> clientes, Banco banco){
        System.out.println("### CADASTRO CONTA ###");
        Scanner le = new Scanner(System.in);
        Cliente esc = clienteSelecionado(clientes);
        
        //escolher tipo de Conta  
        System.out.println("Informe o tipo de Conta (P)oupança ou (C)onta Especial?");
        String resp = le.next();        
        Conta c = (resp.equals("P"))?new Poupanca():new ContaEspecial(0);
        
        //Ler dados da conta      
        if ( c instanceof ContaEspecial){
            System.out.println("Informe o Limite de Credito: ");
            ((ContaEspecial)c).setLimite( le.nextDouble() );
        }
        System.out.println("Numero: ");
        c.setNumero( le.next() ); 
          
        //Guardar conta no cliente e no banco
        esc.addConta( c );
        banco.addConta( c );        
    }
    
    public static Cliente clienteSelecionado(ArrayList<Cliente> clientes){
        System.out.println("### escolha um cliente");
        Scanner le = new Scanner(System.in);
        int i=1;
        for(Cliente c : clientes){
           System.out.println("### "+(i++)+") "+c.getNome() );            
        }
        return clientes.get( le.nextInt()-1 );
    }
    
    public static Cliente cadastraCliente(){
        Scanner le = new Scanner(System.in);
        System.out.println("### CADASTRO CLIENTE ###");
        Cliente c = new Cliente();
        System.out.println("# Nome do Cliente:");
        c.setNome( le.nextLine() );
        System.out.println("# CPF do Cliente:");
        c.setCpf( le.nextLine() );
        System.out.println("# Salario do Cliente:");
        c.setSalario( le.nextDouble() );
        return c;
    }
    
    public static int montaMenu(Scanner a){        
        System.out.println("##### SysBank #######");
        System.out.println("####### MENU ########");
        System.out.println("## 1) Cadastrar Cliente");
        System.out.println("## 2) Cadastrar Conta");
        System.out.println("## 3) Realizar Operaçoes");
        System.out.println("## 4) Relatorios");
        System.out.println("## 5) Sair");
        return a.nextInt();        
    }
    
    
}
