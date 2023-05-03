import java.sql.SQLOutput;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Loteria loteria = new Loteria();
        int op;

        while(true){
            exibeMenu();
            op = sc.nextInt();

            switch (op){
                case 1:
                    while(true){
                        cadastraApostadorCartao(loteria);

                        System.out.println("\nContinuar cadastro de apostadores?\n1-sim | 2-não");
                        if(sc.nextInt() != 1){
                            break;
                        }
                    }
                    break;

                case 2:
                    exibeGabarito(loteria);
                    break;

                case 3:
                    return;
            }
        }
    }

    public static void cadastraApostadorCartao(Loteria loteria){
        Scanner sc = new Scanner(System.in);
        Apostador ap = new Apostador();
        int cont = 1;

        System.out.println("\n# CADASTRO APOSTADOR #");
        System.out.print("# Insira seu nome: ");
        ap.setNome(sc.next());

        while(true){
            Cartao c = new Cartao();
            System.out.println(ap.getNome() + " faça seu " +  cont + " jogo: ");
            System.out.print("Insira o numero do cartao: ");
            c.setNumero(sc.nextInt());

            for(int i = 0; i < c.getRespostas().length; i++){
                int aux = i+1;
                System.out.println("Insira o palpite do jogo " + aux + ":");
                c.getRespostas()[i] = sc.nextInt();
            }

            cont++;

            loteria.contaAcertos(c);
            ap.addCartao(c);

            System.out.print("Deseja criar mais um cartão de apostas? 1 - sim | 2 - não: ");

            if(sc.nextInt() != 1){
                break;
            }
        }

        loteria.getApostadores().add(ap);

        exibeResultadoCartaoApostador(ap);

    }

    private static void exibeResultadoCartaoApostador(Apostador ap){
        System.out.println("\n" + ap.getNome() + ", essas são as quantidades de acerto dos seus cartões: ");

        for(Cartao c : ap.getCartoes()){
            System.out.println("Cartão numero " + c.getNumero() + " - " + c.getQtdAcertos() + " acertos.");

            if(c.getQtdAcertos() == 13){
                System.out.println("# Cartão numero " + c.getNumero() + " foi ganhador #");
            }
        }
    }

    public static void exibeGabarito(Loteria lot){
        System.out.println("\n## Gabarito: ##");
        for(int i = 0; i < lot.getGabarito().length; i++){
            System.out.print(lot.getGabarito()[i] + " ");
        }
    }

    public static void exibeMenu(){
        System.out.println("\n## MENU ##");
        System.out.println("# 1 - Cadastrar apostador e fazer jogos");
        System.out.println("# 2 - Visualizar gabarito");
        System.out.println("# 3 - Sair");
        System.out.print("# Escolha uma opção: ");
    }
}