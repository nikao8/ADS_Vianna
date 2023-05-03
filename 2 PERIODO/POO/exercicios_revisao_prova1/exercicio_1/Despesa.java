
public class Despesa
{
    private int mesAno;
    private String descricao;
    private double valor;
    private boolean taxaExtra;
    
    public Despesa(){}
    
    public Despesa(int mesAno, String descricao, double valor, boolean taxaExtra){
     this.mesAno = mesAno;
     this.descricao = descricao;
     this.valor = valor;
     this.taxaExtra = taxaExtra;
    }
    
    public void setMesAno(int mesAno){
        this.mesAno = mesAno;
    }
    
    public int getMesAno(){
        return mesAno;
    }
    
    public void setDescricao(String descricao){
        this.descricao = descricao;
    }
    
    public String getDescricao(){
        return descricao;
    }
    
    public void setValor(double valor){
        this.valor = valor;
    }
    
    public double getValor(){
        return valor;
    }
    
    public void setTaxaExtra(boolean taxaExtra){
        this.taxaExtra = taxaExtra;
    }
    
    public boolean getTaxaExtra(){
        return taxaExtra;
    }

}
