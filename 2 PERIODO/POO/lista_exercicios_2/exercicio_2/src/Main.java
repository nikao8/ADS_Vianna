import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Professor prof = new Professor();
        Scanner sc = new Scanner(System.in);

        cadastraProfessor(prof);

        do{
            int op;
            cadastraDisciplina(prof);

            System.out.print("\nCadastrar mais 1 disciplina? [1 - sim | 2 - não]: ");
            op = sc.nextInt();

            if(op != 1){
                break;
            }
        }while(true);

        System.out.println("Salario mensal do professor "+ prof.getNome() + " é de R$" + prof.calculaSalarioMensal());
    }

    public static void cadastraProfessor(Professor p){
        Scanner sc = new Scanner(System.in);

        System.out.println("# CADASTRO PROFESSOR #");

        System.out.print("Insira seu nome: ");
        p.setNome(sc.next());

        System.out.print("Graduado? [s ou n]: ");
        p.setGraduado(sc.next().charAt(0) == 's' ? true : false);


        System.out.print("Possui especializacao? [s ou n]: ");
        p.setEspecializacao(sc.next().charAt(0) == 's' ? true : false);


        System.out.print("Doutorado? [s ou n]: ");
        p.setDoutor(sc.next().charAt(0) == 's' ? true : false);


        System.out.print("Mestre? [s ou n]: ");
        p.setMestre(sc.next().charAt(0) == 's' ? true : false);

    }

    public static void cadastraDisciplina(Professor p){
        Disciplina d = new Disciplina();
        Scanner sc = new Scanner(System.in);

        System.out.println("# CADASTRO DISCIPLINA #");

        System.out.print("Insira o nome da disciplina: ");
        d.setNome(sc.next());

        System.out.print("Disciplina EAD ? [s ou n]: ");
        d.setEad(sc.next().charAt(0) == 's' ? true : false);

        System.out.print("Insira os creditos semanais da disciplina: ");
        d.setCreditosSemanais(sc.nextInt());

        p.addDisciplina(d);
    }
}