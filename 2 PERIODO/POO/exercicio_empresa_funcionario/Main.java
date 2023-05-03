import java.util.Scanner;

public class Main
{
    
    public static void main(String[] args){
        
        Scanner le = new Scanner(System.in);
        
        //System.out.println("Informe O numero de Funcionarios");
        Empresa emp = new Empresa("", "");
        System.out.println("Nome da Empresa");
        emp.setNome( le.next() );
        System.out.println("Cnpj da Empresa");
        emp.setCNPJ( le.next() );
        
        System.out.println("## Funcionarios");
        
        //for (int i=0; i< emp.getMeusFuncionarios().size(); i++){
        while (true){            
            Funcionario f = new Funcionario();
            System.out.println("### Nome:");
            le.nextLine();
            f.setNome( le.nextLine() );
            System.out.println("### Numero de Filhos:");
            f.setNumeroFilhos( le.nextInt() );
            System.out.println("### Salario Bruto:");
            f.setSalarioBruto( le.nextDouble() );
            System.out.println("### Usa Vale Transporte?");
            f.usaValeTransporte = le.nextBoolean();
            System.out.println("### Trabalha a noite (S/N)?");
            f.ehTrabalhadorNoturno = 
            ( le.next().equalsIgnoreCase("S") );            
            System.out.println("### Nome : "+f.getNome() );
            System.out.println("### Numero Filhos : "+f.getNumeroFilhos());            
            emp.addFuncionario( f);
             System.out.println("### Desseja Cadastrar outro (S/N)? ");
             if (le.next().equalsIgnoreCase("N")){
                break; 
             }            
        }
        
        System.out.println("####### Total de Salarios");
        System.out.println("R$ "+emp.salariosPagos());
        
        
        
        
        
    }
    
}
