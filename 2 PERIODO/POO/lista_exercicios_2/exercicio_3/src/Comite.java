import java.util.ArrayList;

public class Comite{
    private ArrayList<Artigo> artigos;
    private ArrayList<Artigo> vencedores;
    public Comite(){
        artigos = new ArrayList<Artigo>();
        vencedores = new ArrayList<Artigo>();
    }
    public void addArtigo(Artigo artigo){
        this.artigos.add(artigo);
    }

    public ArrayList<Artigo> getVencedores() {
        return vencedores;
    }

    public void addVencedor(Artigo v) {
        this.vencedores.add(v);
    }

    public void verificaNotas(){
        int i = 0;
        int i1 = 0;
        int i2= 0;
        int i3 = 0;

        int aux = 0;
        int aux2 = 0;
        int aux3 = 0;

        for(Artigo a : artigos){

            if(a.getNota() > aux){
                aux = a.getNota();
                i1 = i;
            }

            if(a.getNota() < aux && a.getNota() > aux2){
                aux2 = a.getNota();
                i2 = i;
            }

            if(a.getNota() < aux && a.getNota() < aux2 && a.getNota() > aux3 ){
                aux3 = a.getNota();
                i3 = i;
            }
            i++;
        }

        vencedores.add(artigos.get(i1));
        vencedores.add(artigos.get(i2));
        vencedores.add(artigos.get(i3));
    }
}