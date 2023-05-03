import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Turma turma = new Turma();
        int opcao = 0;

        while(opcao != 4)
        {

            exibeMenu();
            opcao = sc.nextInt();

            switch (opcao){
                case 1:
                    System.out.println("# Insira a quantidade de alunos para cadastrar: ");
                    int qtdAlunos = sc.nextInt();

                    for (int i = 0; i < qtdAlunos; i++)
                    {
                        cadastraAluno(turma);
                    }

                    break;

                case 2:

                    exibeAlunosCadastrados(turma);

                    for(Aluno aluno : turma.getAlunos())
                    {
                        System.out.println(aluno.getNome() + " é a sua vez de votar, para votar, digite o id do aluno para computar seu voto nele, Digite: ");
                        int id = sc.nextInt();
                        computaVotoAluno(turma, id);
                    }

                    break;

                case 3:
                    exibeResultadoVotacao(turma);
                    break;

                case 4:
                    break;
            }
        }
    }

    public static void exibeResultadoVotacao(Turma turma)
    {
        System.out.println("O aluno mais votado foi: " + turma.getAlunoGanhador().getNome() + ", com " + turma.getAlunoGanhador().getQtdVotos() + " votos e um percentual de: " + turma.calculaPercentualMaisVotado() + "%.");
    }

    public static void computaVotoAluno(Turma turma, int id)
    {
        for(Aluno aluno : turma.getAlunos())
        {
            if(aluno.getIdAluno() == id)
            {
                aluno.setQtdVotos();
            }
        }
    }

    public static void cadastraAluno(Turma turma)
    {
        Scanner sc = new Scanner(System.in);
        Aluno aluno = new Aluno();

        System.out.println("### CADASTRO DE ALUNO: ###");

        System.out.println("# Insira o seu nome: ");
        aluno.setNome(sc.next());

        turma.adicionaAluno(aluno);
    }

    public static void exibeAlunosCadastrados(Turma turma)
    {
        System.out.println("## LISTA DE ALUNOS: ###");

        for(Aluno aluno : turma.getAlunos())
        {
            System.out.println( aluno.getIdAluno() + " - " + aluno.getNome() );
        }

    }

    public static void exibeMenu()
    {
        System.out.println("\n#### ESCOLHA UMA OPÇÃO: ####");
        System.out.println("### MENU: ###");
        System.out.println("1 - Cadastrar alunos");
        System.out.println("2 - Realizar votação");
        System.out.println("3 - Visualizar resultado da votação");
        System.out.println("4 - Finalizar programa");
    }
}