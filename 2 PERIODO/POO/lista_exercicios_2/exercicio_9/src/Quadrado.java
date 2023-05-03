
public class Quadrado
{
    private Linha linha1;
    private Linha linha2;
    private Linha linha3;
    private Linha linha4;
    
    public Quadrado(){
    }
      
    public double retornaPerimetro(){
        double aux = 0;
        aux= linha1.retornaTamanhoLinha()+ linha2.retornaTamanhoLinha()+ linha3.retornaTamanhoLinha()+ linha4.retornaTamanhoLinha();

        return aux;
    }
    
    public void setl1(Linha l1){
        this.linha1 =l1;
    }
    public Linha getl1(){
        return linha1;
    }
    public void setl2(Linha l2){
        this.linha2 =l2;
    }
    public Linha getl2(){
        return linha2;
    }
    public void setl3(Linha l3){
        this.linha3 =l3;
    }
    public Linha getl3(){
        return linha3;
    }
    public void setl4(Linha l4){
        this.linha4 =l4;
    }
    public Linha getl4(){
        return linha4;
    }

}
