import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Emprestimo emp = new Emprestimo();

        preencheInformacoesEmprestimo(emp);
        retornaInformacoesEmprestimo(emp);
    }

    public static void preencheInformacoesEmprestimo(Emprestimo emp)
    {
        Scanner sc = new Scanner(System.in);

        System.out.println("### CADASTRO DE EMPRESTIMO ###");

        System.out.println("# Insira o valor a ser pego emprestado: ");
        emp.setValorTotalEmprestimo(sc.nextDouble());

        System.out.println("# Insira o valor da taxa de juros em %: ");
        emp.setJurosMensal(sc.nextDouble());

        System.out.println("# Insira a quantidade de meses para o emprestimo ser pago: ");
        emp.setQtdMeses(sc.nextInt());

        sc.close();
    }

    public static void retornaInformacoesEmprestimo(Emprestimo emp)
    {
        System.out.println("### EMPRESTIMO: ###");
        System.out.println("# Valor do emprestimo: " + emp.getValorTotalEmprestimo());
        System.out.println("# Taxa de juros: " + emp.getJurosMensal() + "%");
        System.out.println("# Quantidade de meses: " + emp.getQtdMeses() + "\n");


        System.out.println("\nValor da mensalidade: " + emp.valorMensalidade());
        System.out.println("Valor total pago ao final do empréstimo: " + emp.valorPagoFinal());
        System.out.println("Total pago de juros: " + emp.valorPagoJuros());
    }
}