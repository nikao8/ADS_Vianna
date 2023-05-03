
public class Disciplina {
    private int creditosSemanais;
    private String nome;
    private int horasMensais;
    private boolean ead;

    public Disciplina(){}

    public int getCreditosSemanais() {
        return creditosSemanais;
    }

    public void setCreditosSemanais(int creditosSemanais) {
        this.creditosSemanais = creditosSemanais;
        this.horasMensais = creditosSemanais * 4;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getHorasMensais() {
        return horasMensais;
    }

    public void setEad(boolean ead) {
        this.ead = ead;
    }

    public boolean isEad() {
        return ead;
    }
}
