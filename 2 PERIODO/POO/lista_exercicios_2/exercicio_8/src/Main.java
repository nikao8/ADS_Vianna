import java.util.Scanner;

public class Main
{
   public static void main (String args[]){
       Scanner sc = new Scanner(System.in);
       Corretor corr = new Corretor();
       System.out.println("Insira o nome do Corretor: ");
       corr.setNome(sc.next());
       System.out.println("Insira a idade do Corretor: ");
       corr.setIdade(sc.nextInt());
       
       System.out.println("### CADASTRO DE IMOVEIS ###");
       while(true){
           corr.addImovel(cadastraImovel());
           System.out.println("Cadastrar novo imóvel? s - sim | n - não");

           if (sc.next().toLowerCase().equals("n")){
               break;
           }
           
       }
       while(true){
           System.out.println("PREÇO DE VENDA DOS IMÓVEIS CADASTRADOS:");
           int cont = 0;

           for (Imovel i: corr.getImoveis()){
               System.out.println((cont+1)+". Endereço: "+i.getEndereco()+"-Preço R$ "+i.precoFim());
               cont++;
           }

           System.out.println("Retirar da lista algum imóvel? s - sim | cont - não");

           if (sc.next().toLowerCase().equals("s")){

                System.out.println("Digite uma posição:");
                int pos = sc.nextInt();

                corr.removeImovel(corr.getImoveis().get(pos-1));
           }
           System.out.println("Deseja visualizar a lista de imóveis novamente? s/cont");
           String opc3 = sc.next();
           if (opc3.equalsIgnoreCase("cont")){
                break;
            }
        }
    }
    
   public static Imovel cadastraImovel(){
       Scanner sc = new Scanner(System.in);
       Imovel i;

       System.out.println("O imovel é antigo?");
       String esc = sc.next();

       if (esc.toLowerCase().equals("s")){
            ImovelAntigo imAnt = new ImovelAntigo();

            System.out.println("Insira a porcentagem de desconto");

            imAnt.setpDesc(sc.nextInt());
            i=imAnt;
       }else{
            i = new Imovel("",0.0);
       }

       System.out.println("Insira o endereço:");
       i.setEndereco(sc.next());
       System.out.println("Insira o preço");
       i.setPreco(sc.nextDouble());

       return i;
    }    
}
