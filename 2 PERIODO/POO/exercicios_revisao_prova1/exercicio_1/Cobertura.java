
public class Cobertura extends Imovel
{
    private boolean duplex;
    private boolean triplex;
    
    public Cobertura(){
        super(0,0,"");
    }
    
    public void setDuplex(boolean duplex){
        this.duplex = duplex;
    }
    
    public boolean getDuplex(){
        return duplex;
    }
    
    public void setTriplex(boolean triplex){
        this.triplex = triplex;
    }
    
    public boolean getTriplex(){
        return triplex;
    }
    
    @Override
    public double valorVenal(){
        return super.valorVenal() * (duplex ? 2 : 1) * (triplex ? 3 : 1);
    }

}
