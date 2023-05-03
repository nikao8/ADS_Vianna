import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Funcionario func = new Funcionario();

        preencheCadastroFuncionario(func);
        imprimeInformacoesSalarioFuncionario(func);
    }

    public static void preencheCadastroFuncionario(Funcionario func)
    {
        Scanner sc = new Scanner(System.in);

        System.out.print("Insira o nome do funcionario: ");
        func.setNome(sc.next());

        System.out.print("Insira a quantidade de horas trabalhadas pelo funcionario: ");
        func.setQtdHorasTrabalhadas(sc.nextInt());

        System.out.print("Insira o salario-hora do funcionario: ");
        func.setSalarioHora(sc.nextDouble());

        System.out.print("Insira a quantidade de dependentes do funcionario: ");
        func.setQtdDependentes(sc.nextInt());

        sc.close();
    }

    public static void imprimeInformacoesSalarioFuncionario(Funcionario func){
        System.out.println("##########################\nOlá " + func.getNome() + ", aqui vai algumas informações do seu salário:");
        System.out.println("Salário bruto: R$" + func.calculaSalarioBruto());
        System.out.println("Desconto INSS: R$" + func.calculaDescontoINSS());
        System.out.println("Desconto Imposto de renda: R$" + func.calculaIR());
        System.out.println("Salario liquido: R$" + func.calculaSalarioLiquido() + "\n##########################\n");
    }
}