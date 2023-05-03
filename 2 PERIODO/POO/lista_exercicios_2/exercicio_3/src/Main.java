import java.util.Scanner;
public class Main{
    public static void main(String[] args){

        Scanner sc = new Scanner(System.in);
        Comite c = new Comite();

        System.out.println("### CADASTRO DE ARTIGOS ###");

        while(true){
            System.out.println("# Insira o titulo e o resumo em seguida:");
            Artigo artigo = new Artigo(sc.next(), sc.next());
            sc.nextLine();

            System.out.println("# Insira o nome do professor:");
            Professor p = new Professor(sc.next());
            sc.nextLine();
            artigo.addProfessor(p);

            System.out.println("# Insira o nome do Orientador:");
            Orientador ori = new Orientador(sc.next());
            sc.nextLine();
            artigo.addOrientador(ori);

            while(true){
                System.out.println("## Cadastre os alunos:");
                Aluno aluno = new Aluno(sc.next());
                artigo.addAluno(aluno);

                System.out.print("1- continuar cadastro de alunos | 2 - sair");
                if(sc.nextInt() != 1){
                    break;
                }
            }

            System.out.println("Insira a nota do artigo:");
            artigo.setNota(sc.nextInt());

            System.out.print("1- continuar cadastro de artigos | 2 - sair");
            if(sc.nextInt() != 1){
                break;
            }

            c.addArtigo(artigo);
        }

        c.verificaNotas();
        imprimeVencedores(c);
    }

    public static void imprimeVencedores(Comite c){
        int i = 1;
        for(Artigo a : c.getVencedores()){
            System.out.println("Nota " + i + ": - Titulo: " + a.getTitulo() + " | Nota: " + a.getNota());
            i++;
        }
    }
}