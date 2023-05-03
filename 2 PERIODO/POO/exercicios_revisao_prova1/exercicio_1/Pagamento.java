public class Pagamento
{
    private int mesAno;
    private double valorPago;
    private Imovel imovel;
    private Condominio condominio;
    
    public Pagamento(){}
    
    public Pagamento(int mesAno, double valorPago, Imovel imovel, Condominio condominio){
        this.mesAno = mesAno;
        this.valorPago = valorPago;
        this.imovel = imovel;
        this.condominio = condominio;
    }
    
    public void setMesAno(int mesAno){
        this.mesAno = mesAno;
    }
    
    public int getMesAno(){
        return mesAno;
    }
    
    public void setValorPago(double valorPago){
        this.valorPago = valorPago;
    }
    
    public double getValorPago(){
        return valorPago;
    }
    
    public void setImovel(Imovel imovel){
        this.imovel = imovel;
    }
    
    public Imovel getImovel(){
        return imovel;
    }
    
    public void setCondominio(Condominio condominio){
        this.condominio = condominio;
    }
    
    public Condominio getCondominio(){
        return condominio;
    }
}
