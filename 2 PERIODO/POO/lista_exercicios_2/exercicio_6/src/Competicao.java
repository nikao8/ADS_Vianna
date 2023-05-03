import java.util.ArrayList;

public class Competicao {
    private ArrayList<Competidor> competidores;

    public Competicao(){
        this.competidores = new ArrayList<Competidor>();
    }

    public ArrayList<Competidor> getCompetidores() {
        return competidores;
    }

    public void addCompetidor(Competidor c) {
        this.competidores.add(c);
    }
}
