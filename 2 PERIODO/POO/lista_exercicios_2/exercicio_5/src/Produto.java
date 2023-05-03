public class Produto {
    private long codigo;
    private String nome;

    public Produto(){

    }

    public String consultaNome(){
        return this.nome;
    }


    public long getCodigo() {
        return codigo;
    }

    public void setCodigo(long codigo) {
        this.codigo = codigo;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }
}


