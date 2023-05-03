public class Consumidor {
    private String nome;
    private String cpf;
    private Carro carro;

    public Consumidor()
    {
        this.nome = "";
        this.cpf = "";
        carro = new Carro();
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public Carro getCarro() {
        return carro;
    }

    public void setCarro(Carro carro) {
        this.carro = carro;
    }
}
