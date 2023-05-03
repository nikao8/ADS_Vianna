import java.util.ArrayList;

public class Pescador {
    private String nome;
    private ArrayList<Peixe> peixes;
    private double multa;

    public Pescador(){
        this.multa = 0;
        this.peixes = new ArrayList<Peixe>();
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public ArrayList<Peixe> getPeixes() {
        return peixes;
    }

    public void addPeixe(Peixe peixe) {
        this.peixes.add(peixe);
    }

    public double getMulta() {
        return multa;
    }

    public void setMulta(double multa) {
        this.multa = multa;
    }

    public double calculaMulta(){
        for(Peixe p : peixes){
            if(p.getPeso() > 50.0){
                this.multa += 4 * (p.getPeso() - 50.0) ;
            }
        }

        return this.multa;
    }
}
