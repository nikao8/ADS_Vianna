
public class Apartamento extends Imovel
{
    private int numeroQuarto;
    
    public Apartamento(){
        super(0,0,"");
    }
    
    public Apartamento(int numeroQuarto){
        super(0,0,"");
        this.numeroQuarto = numeroQuarto;
    }

    public void setNumeroQuarto(int numeroQuarto){
        this.numeroQuarto = numeroQuarto;
    }
    
    public int getNumeroQuarto(){
        return numeroQuarto;
    }
    
    @Override
    public double valorVenal(){
        return super.valorVenal() + (500 * numeroQuarto);
    }
}
