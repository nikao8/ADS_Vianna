import java.util.ArrayList;

public class Populacao {
    private ArrayList<Habitante> habitantes;
    private String nomeRegiao;

    public Populacao(){
        habitantes = new ArrayList<Habitante>();
    }

    public ArrayList<Habitante> getHabitantes() {
        return habitantes;
    }

    public String getNomeRegiao() {
        return nomeRegiao;
    }

    public void setNomeRegiao(String nomeRegiao) {
        this.nomeRegiao = nomeRegiao;
    }

    public void adicionaHabitante(Habitante habitante) {
        habitantes.add(habitante);
    }

    public double maiorAltura() {

        int indiceMaior = 0;

        for(int i = 0; i < habitantes.size(); i++)
        {
            if(habitantes.get(i).getAltura() >= habitantes.get(indiceMaior).getAltura())
            {
                indiceMaior = i;
            }
        }

        return habitantes.get(indiceMaior).getAltura();
    }

    public double menorAltura() {

        int indiceMenor = 0;

        for(int i = 0; i < habitantes.size(); i++)
        {
            if(habitantes.get(i).getAltura() <= habitantes.get(indiceMenor).getAltura())
            {
                indiceMenor = i;
            }
        }

        return habitantes.get(indiceMenor).getAltura();
    }

    public int quantidadeMulheres() {
        int contadorMulheres = 0;

        for(Habitante h : habitantes)
        {
            if(h.getSexo() == 'f')
            {
                contadorMulheres++;
            }
        }

        return contadorMulheres;
    }

    public int quantidadeHomens() {
        int contadorHomens = 0;

        for(Habitante h : habitantes)
        {
            if(h.getSexo() == 'm' )
            {
                contadorHomens++;
            }
        }

        return contadorHomens;
    }

    public double mediaAlturaMulheres() {
        double somaAlturas = 0;

        for (Habitante h : habitantes)
        {
            if(h.getSexo() == 'f')
            {
                somaAlturas += h.getAltura();
            }
        }

        return somaAlturas / quantidadeMulheres();
    }

    public double porcentagemHomens() {
        int qtdTotal = quantidadeHomens() + quantidadeMulheres();

        return Double.valueOf((quantidadeHomens() * 100)) / qtdTotal;
    }

    public double porcentagemMulheres(boolean condicional) {
        int qtdTotal = quantidadeHomens() + quantidadeMulheres();

        if(condicional)
        {
            int qtdMulheresCondicionais = 0;

            for (Habitante h : habitantes)
            {
                if(h.getSexo() == 'f' && (h.getIdade() > 18 && h.getIdade() < 35) && h.getCorCabelo() == 'l' && h.getCorOlho() == 'v'){
                    qtdMulheresCondicionais++;
                }
            }

            return Double.valueOf((qtdMulheresCondicionais * 100)) / qtdTotal;
        }
        else {
            return Double.valueOf((quantidadeMulheres() * 100)) / qtdTotal;
        }
    }



}
