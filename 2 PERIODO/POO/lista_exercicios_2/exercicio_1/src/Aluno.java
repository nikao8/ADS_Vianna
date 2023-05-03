import java.util.concurrent.ThreadLocalRandom;

public class Aluno {
    private int idAluno;
    private String nome;
    private int qtdVotos;

    public Aluno()
    {
        qtdVotos = 0;
        idAluno = ThreadLocalRandom.current().nextInt(1, 500);
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getQtdVotos() {
        return qtdVotos;
    }

    public void setQtdVotos() {
        this.qtdVotos++;
    }

    public int getIdAluno()
    {
        return idAluno;
    }

}
