public class Empregado {
    private String nome;
    private int idade;
    private int anosTrabalhados;

    public Empregado(){
        this.nome = "";
        this.idade = 0;
        this.anosTrabalhados = 0;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public int getAnosTrabalhados() {
        return anosTrabalhados;
    }

    public void setAnosTrabalhados(int anosTrabalhados) {
        this.anosTrabalhados = anosTrabalhados;
    }

    public boolean atendeAposentadoria(){
        if(idade >= 65 && anosTrabalhados >= 30)
        {
            return true;
        }

        return false;
    }
}
