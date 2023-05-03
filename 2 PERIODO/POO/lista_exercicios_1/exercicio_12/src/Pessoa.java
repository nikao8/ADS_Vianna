public class Pessoa {
    private String nome;
    private String diaNascimento;
    private String mesNascimento;
    private String anoNascimento;
    private String dataNascimento;

    public Pessoa(){}

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getDiaNascimento() {
        return diaNascimento;
    }

    public void setDiaNascimento(String diaNascimento) {
        this.diaNascimento = diaNascimento;
    }

    public String getMesNascimento() {
        return mesNascimento;
    }

    public void setMesNascimento(String mesNascimento) {
        this.mesNascimento = mesNascimento;
    }

    public String getAnoNascimento() {
        return anoNascimento;
    }

    public void setAnoNascimento(String anoNascimento) {
        this.anoNascimento = anoNascimento;
    }

    public String getDataNascimento() {
        return dataNascimento;
    }

    public void setDataNascimento() {
        Data tempData = new Data(diaNascimento,mesNascimento,anoNascimento);
        this.dataNascimento = tempData.getDataCompleta();
    }
}
