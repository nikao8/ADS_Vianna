public class ImovelAntigo extends Imovel
{
    private int pDesc;
    public ImovelAntigo(){
        super("",0.0);

        this.pDesc = pDesc;
    }
    public void setpDesc(int pDesc){
       this.pDesc = pDesc;
    }
    
    @Override
    public double precoFim(){
        return super.preco - ( (preco * pDesc) / 100);
    }   
}
