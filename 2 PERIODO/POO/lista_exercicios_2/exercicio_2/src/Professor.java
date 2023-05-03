import java.util.ArrayList;

public class Professor {
    private String nome;
    private double salario;
    private boolean graduado;
    private boolean especializacao;
    private boolean mestre;
    private boolean doutor;
    private ArrayList<Disciplina> disciplinas;

    public Professor(){
        this.disciplinas = new ArrayList<Disciplina>();
        this.doutor = false;
        this.especializacao = false;
        this.mestre = false;
        this.graduado = true;
        this.salario = 0;
    }

    public void setGraduado(boolean graduado) {
        this.graduado = graduado;
    }

    public void setEspecializacao(boolean especializacao) {
        this.especializacao = especializacao;
    }

    public void setMestre(boolean mestre) {
        this.mestre = mestre;
    }

    public void setDoutor(boolean doutor) {
        this.doutor = doutor;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public double getSalario() {
        return salario;
    }

    public ArrayList<Disciplina> getDisciplinas() {
        return disciplinas;
    }

    public void addDisciplina(Disciplina d) {
        this.disciplinas.add(d);
    }

    public boolean isGraduado() {
        return graduado;
    }

    public boolean isEspecializacao() {
        return especializacao;
    }

    public boolean isMestre() {
        return mestre;
    }

    public boolean isDoutor() {
        return doutor;
    }

    private double calculaHoraAula(){
        double horaAula = 0;

        if(graduado){
            horaAula += 25;
        }

        if(especializacao){
            horaAula += horaAula * 0.15;
        }

        if(mestre){
            horaAula += horaAula * 0.45;
        }

        if(doutor){
            horaAula += horaAula * 0.75;
        }

        return horaAula;
    }

    public double calculaSalarioMensal(){
        double salarioCalculado = 0;
        double horaAula = calculaHoraAula();

        for(Disciplina d : disciplinas){
            if(d.isEad()){
                salarioCalculado += (horaAula - (horaAula * 0.25)) * d.getHorasMensais();
            }
            else{
                salarioCalculado += horaAula * d.getHorasMensais();
            }
        }

        this.salario = salarioCalculado;
        return salarioCalculado;
    }
}
