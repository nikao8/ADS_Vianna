public class Habitante {
    private char sexo;
    private char corOlho;
    private char corCabelo;
    private int idade;
    private double altura;

    public Habitante(){}

    public char getSexo() {
        return sexo;
    }

    public void setSexo(char sexo) {
        this.sexo = sexo;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }

    public char getCorOlho() {
        return corOlho;
    }

    public void setCorOlho(char corOlho) {
        this.corOlho = corOlho;
    }

    public char getCorCabelo() {
        return corCabelo;
    }

    public void setCorCabelo(char corCabelo) {
        this.corCabelo = corCabelo;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }
}
