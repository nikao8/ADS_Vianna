import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int op;
        Scanner sc = new Scanner(System.in);
        Pescador pesc = new Pescador();

        cadastraPescador(pesc);

        while (true){
            menu();
            op = sc.nextInt();

            switch (op){
                case 1:
                    cadastraPeixePescado(pesc);
                    break;
                case 2:
                    System.out.println("Multas a pagar: " + pesc.calculaMulta());
                    break;
                case 3:
                    return;
            }

        }
    }

    public static void cadastraPescador(Pescador pesc){
        Scanner sc = new Scanner(System.in);
        System.out.println("### CADASTRO DO PESCADOR ###");
        System.out.println("## Insira seu nome: ");
        pesc.setNome(sc.next());
    }

    public static void cadastraPeixePescado(Pescador pesc){
        Scanner sc = new Scanner(System.in);
        Peixe peixe = new Peixe();

        System.out.println("### CADASTRO PEIXE PESCADO ###");

        System.out.println("## Insira o nome/especie do peixe que pescou: ");
        peixe.setNome(sc.next());

        System.out.println("## Insira o peso em kg do peixe que pescou: ");
        peixe.setPeso(sc.nextDouble());

        pesc.addPeixe(peixe);
    }

    public static void menu(){
        System.out.println("\n### ESCOLHA UMA OPCAO ABAIXO ###");
        System.out.println("## 1 - Cadastrar peixe pescado");
        System.out.println("## 2 - Visualizar multas pendentes");
        System.out.println("## 3 - Sair\n");
    }
}