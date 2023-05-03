
public class Imovel
{
    private String endereco;
    protected double preco;
    
    public Imovel(String endereco, double preco){
        this.endereco = endereco;
        this.preco = preco;
    }
    public double precoFim(){
        return preco;
    }
    public void setEndereco(String endereco){
        this.endereco=endereco;
    }
    public String getEndereco(){
        return endereco;
    }
    public void setPreco(double preco){
        this.preco=preco;
    }
    public double getPreco(){
        return preco;
    }

}
