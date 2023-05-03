public class Pessoa
{
    private String nome;
    private Universidade universidade;

    public Pessoa(){
    }

    public String retornaFrase(){
        String aux = this.getNome()+ " trabalha na "+ universidade.getNome();
        return aux;
    }
    public void setNome (String nome){
        this.nome=nome;
    }
    public String getNome(){
        return nome;
    }
    public void setUniversidade (Universidade universidade){
        this.universidade=universidade;
    }
    public Universidade getUniversidade(){
        return universidade;
    }

}
