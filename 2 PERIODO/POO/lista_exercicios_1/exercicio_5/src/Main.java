import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Empregado emp = new Empregado();

        preencheInfoEmpregado(emp);
        imprimeResultadoAposentadoria(emp);
    }

    public static void preencheInfoEmpregado(Empregado emp)
    {
        Scanner sc = new Scanner(System.in);

        System.out.println("Insira seu nome: ");
        emp.setNome(sc.next());

        System.out.println("Insira sua idade: ");
        emp.setIdade(sc.nextInt());

        System.out.println("Insira a quantidade de anos trabalhados: ");
        emp.setAnosTrabalhados(sc.nextInt());

        sc.close();
    }

    public static void imprimeResultadoAposentadoria(Empregado emp){
        String resultadoAposentadoria = (emp.atendeAposentadoria() == true ? "Aprovado" : "Reprovado");
        System.out.println(emp.getNome() +", a sua aposentadoria está no status de: " + resultadoAposentadoria);
    }

}