import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Pessoa p = new Pessoa();
        Data dataAtual = new Data();

        cadastraPessoa(p);

        System.out.println("Data hoje: " + dataAtual.getDataCompleta());
        System.out.println("Data nascimento: " + p.getDataNascimento().toString());
        System.out.println(p.getNome()  + ", você tem " + (Integer.parseInt(dataAtual.getAno()) - Integer.parseInt(p.getAnoNascimento())) + " anos!");
    }

    public static void cadastraPessoa(Pessoa p){
        Scanner sc = new Scanner(System.in);

        System.out.print("Insira seu nome: ");
        p.setNome(sc.next());

        System.out.print("Insira o dia do seu nascimento: ");
        p.setDiaNascimento(sc.next());

        System.out.print("Insira o mês do seu nascimento: ");
        p.setMesNascimento(sc.next());

        System.out.print("Insira o ano do seu nascimento: ");
        p.setAnoNascimento(sc.next());

        p.setDataNascimento();
    }
}