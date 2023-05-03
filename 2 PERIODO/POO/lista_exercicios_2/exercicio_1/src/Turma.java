import java.util.ArrayList;

public class Turma {
    private ArrayList<Aluno> alunos;
    private Aluno alunoGanhador;


    public Turma(){
        alunoGanhador = new Aluno();
        alunos = new ArrayList<Aluno>();
    }

    public ArrayList<Aluno> getAlunos() {
        return alunos;
    }

    public void setAlunos(ArrayList<Aluno> alunos) {
        this.alunos = alunos;
    }

    public Aluno getAlunoGanhador() {
        calculaMaisVotado();
        return alunoGanhador;
    }

    /*public void setAlunoGanhador(Aluno alunoGanhador) {
        this.alunoGanhador = alunoGanhador;
    }*/

    public void adicionaAluno(Aluno aluno)
    {
        alunos.add(aluno);
    }

    private void calculaMaisVotado()
    {
        int indiceVencedor = 0;

        for(int i = 0; i < alunos.size(); i++)
        {
            if(alunos.get(i).getQtdVotos() >= alunos.get(indiceVencedor).getQtdVotos())
            {
                indiceVencedor = i;
            }
        }

        //setAlunoGanhador(alunos.get(indiceVencedor));
        this.alunoGanhador = alunos.get(indiceVencedor);
        //return alunos.get(indiceVencedor);
    }

    public double calculaPercentualMaisVotado()
    {
        return (alunoGanhador.getQtdVotos() * 100) / (double)alunos.size();
    }
}
