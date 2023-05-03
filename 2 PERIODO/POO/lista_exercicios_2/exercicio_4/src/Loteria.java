import java.util.ArrayList;
import java.util.concurrent.ThreadLocalRandom;

public class Loteria {

    private int[] gabarito;
    private ArrayList<Apostador> apostadores;

    public Loteria(){
        gabarito = geraGabarito();
        apostadores = new ArrayList<Apostador>();
    }

    private int[] geraGabarito(){
        int[] v = new int[13];

        for(int i = 0; i < v.length; i++){
            v[i] = ThreadLocalRandom.current().nextInt(1,3);
        }

        return v;
    }

    public void contaAcertos(Cartao c){
        int cont = 0;
        int[] resp = c.getRespostas();

        for(int i = 0; i < gabarito.length; i++){
            if(resp[i] == gabarito[i]){
                cont++;
            }
        }

        c.setQtdAcertos(cont);
    }

    // METODOS GET E SET

    public int[] getGabarito() {
        return gabarito;
    }

    public ArrayList<Apostador> getApostadores() {
        return apostadores;
    }

    public void addApostador(Apostador a) {
        this.apostadores.add(a);
    }
}
