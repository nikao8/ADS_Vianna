package ex1;

public class Pontos {
    private double xA;
    private double yA;
    private double xB;
    private double yB;


    public Pontos(){
    }

    public Pontos(double xA, double yA, double xB, double yB){
            this.xA = xA;
            this.yA = yA;
            this.xB = xB;
            this.yB = yB;
    }

    public double getxA() {
        return xA;
    }

    public void setxA(double xA) {
        this.xA = xA;
    }

    public double getyA() {
        return yA;
    }

    public void setyA(double yA) {
        this.yA = yA;
    }

    public double getxB() {
        return xB;
    }

    public void setxB(double xB) {
        this.xB = xB;
    }

    public double getyB() {
        return yB;
    }

    public void setyB(double yB) {
        this.yB = yB;
    }

    public double CalculaDistanciaPontos(){
        //dAB² = (xB – xA)² + (yB – yA)²

        double dAB = Math.sqrt(Math.pow(xB - xA,2) + Math.pow(yB - yA,2));

        return dAB;
    }
}
