import java.util.*;
public class Main {
    public static void main(String[] args) {
        Competicao comp = new Competicao();
        Scanner sc = new Scanner(System.in);
        ArrayList<Integer> ponts = new ArrayList<Integer>();

        Competidor c1 = new Competidor("Nicolas", 1);
        comp.addCompetidor(c1);
        Competidor c2 = new Competidor("Leo", 2);
        comp.addCompetidor(c2);
        Competidor c3 = new Competidor("Juliana", 3);
        comp.addCompetidor(c3);
        Competidor c4 = new Competidor("Fabricio", 4);
        comp.addCompetidor(c4);
        Competidor c5 = new Competidor("Marcos", 5);
        comp.addCompetidor(c5);
        Competidor c6 = new Competidor("Andressa", 6);
        comp.addCompetidor(c6);


        for (Competidor c : comp.getCompetidores()){
            System.out.println("Competidor " + c.getNome() + " deseja trocar de kart? 1-sim | 2-não");
            if(sc.nextInt() == 1){
                c.trocaKart();
                System.out.println("Seu kart secundario foi alterado para primario! (-5 pontos)");
            }
            ponts.add(c.getPontuacao());
        }

        ponts.sort(Comparator.reverseOrder());

        for (int i = 0; i < comp.getCompetidores().size(); i++){
            int aux = i+1;
            boolean x = false;


            String aux1 = "";

            for (Competidor c : comp.getCompetidores()){
                if (c.getPontuacao() == ponts.get(i)){
                    aux1 += c.getNome() + ",";
                }
            }

            System.out.println(aux + " lugar: " + aux1 + " - " + ponts.get(i) + " pontos");

        }
    }
}