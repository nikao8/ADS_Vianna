import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Investimento inv = new Investimento();
        Scanner sc = new Scanner(System.in);
        int esc;

        System.out.print("Insira o valor do investimento inicial: ");
        inv.setInvestimento(sc.nextDouble());

        System.out.print("Insira a taxa de juros por mes: ");
        inv.setTaxaJuros(sc.nextDouble());

        System.out.println("Deseja iniciar o investimento?\n1-Sim | 2-Não");
        esc = sc.nextInt();

        while(esc == 1){
            int mes = inv.getMes() + 1;
            System.out.println("Investimento no mês " + mes + ", deseja continuar??\n1-Sim | 2-Não");
            esc = sc.nextInt();

            if(esc == 1){
                inv.setMes();
            }
        }

        System.out.println("Valor do investimento em " + inv.getMes() + " meses foi de: " + inv.exibeResultadoInvestimento() );
    }
}