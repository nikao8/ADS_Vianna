import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Populacao pop = new Populacao();

        cadastroPopulacao(pop,sc);
        cadastraHabitante(pop);
        imprimeEstatisticas(pop);
    }

    public static void cadastroPopulacao(Populacao pop, Scanner sc){
        System.out.println("### CADASTRO POPULAÇÃO ###");
        System.out.println("# Insira o nome da região da população: ");
        pop.setNomeRegiao(sc.next());
    }

    public static void cadastraHabitante(Populacao pop){
        Scanner sc = new Scanner(System.in);

        int cont = 1;

        System.out.println("\n### CADASTRO DE HABITANTE DA REGIÃO "+ pop.getNomeRegiao() + " ###");

        while(true)
        {
            Habitante hab = new Habitante();
            int esc = 1;

            System.out.println("## HABITANTE " + cont + ": ##");

            System.out.println("# Preencha seu sexo: ('f' para feminino e 'm' para masculino: )");
            hab.setSexo(sc.next().toLowerCase().charAt(0));

            System.out.println("# Insira a cor do seus olhos: ('a' = azul, 'v' = verde, 'c' = castanho): ");
            hab.setCorOlho(sc.next().toLowerCase().charAt(0));

            System.out.println("# Insira a cor do seu cabelo: ('l' = loiro, 'c' = castanho, 'p' = preto): ");
            hab.setCorCabelo(sc.next().toLowerCase().charAt(0));

            System.out.println("# Insira a sua idade em anos: ");
            hab.setIdade(sc.nextInt());

            System.out.println("# Insira a sua altura: ");
            hab.setAltura(sc.nextDouble());

            pop.adicionaHabitante(hab);

            System.out.println("\n### DESEJA CONTINUAR O CADASTRO? ###\n1) Sim\n2) Sair");
            esc = sc.nextInt();

            if(esc != 1){
                break;
            }

            cont++;
        }
    }

    public static void imprimeEstatisticas(Populacao pop){
        System.out.println("\n### ESTATISCICAS DA POPULAÇÃO:");
        System.out.println("# A maior altura é: " + pop.maiorAltura() + "\nA menor altura é: "+ pop.menorAltura() );
        System.out.println("# A média de altura das mulheres é de: " + pop.mediaAlturaMulheres());
        System.out.println("# O numero de homens na população é de: " + pop.quantidadeHomens());
        System.out.println("# A porcentagem de mulheres na população é de: " + pop.porcentagemMulheres(false) + "%");
        System.out.println("# A porcentagem de homens na população é de: " + pop.porcentagemHomens() + "%");
        System.out.println("# A porcentagem de mulheres de idade entre 18 e 35 anos, olhos verdes e cabelos loiros: " + pop.porcentagemMulheres(true) + "%");
    }

}