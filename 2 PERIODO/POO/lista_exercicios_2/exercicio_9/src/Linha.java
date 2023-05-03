public class Linha
{
    private Ponto ponto1;
    private Ponto ponto2;
    public Linha(){
    }


    public double retornaTamanhoLinha(){
        double d1= ponto1.getX()-ponto2.getX();
        double d2=ponto1.getY()-ponto2.getY();
        return Math.sqrt(Math.pow(d1,2) + Math.pow(d2,2));
    }

    public boolean isVertical(){
        if(ponto1.getX()==ponto2.getX()){
            return true;
        }else{
            return false;
        }
    }
    public boolean isHorizontal(){
        if(ponto1.getY()==ponto2.getY()){
            return true;
        }else{
            return false;
        }
    }

    public void setPonto1(Ponto ponto1){
        this.ponto1=ponto1;
    }
    public Ponto getPonto1(){
        return ponto1;
    }
    public void setPonto2(Ponto ponto2){
        this.ponto2=ponto2;
    }
    public Ponto getPonto2(){
        return ponto2;
    }

}
