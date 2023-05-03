import java.util.ArrayList;

public class Artigo{
    private ArrayList<Aluno> alunos = new ArrayList<Aluno>();
    private Orientador orientador = new Orientador();
    private Professor professor = new Professor();
    private String titulo;
    private String resumo;
    private int nota;
    public Artigo(String titulo, String resumo){
        this.resumo = resumo;
        this.titulo = titulo; 
    }

    public void setNota(int nota){
        this.nota = nota;
    }

    public int getNota(){
        return this.nota;
    }
    public String getTitulo(){
        return this.titulo;
    }

    public void addProfessor(Professor professor){
        this.professor = professor;
    }

    public void addOrientador(Orientador orientador){
        this.orientador = orientador;
    }
     public void addAluno(Aluno aluno){
        this.alunos.add(aluno);
    }
}