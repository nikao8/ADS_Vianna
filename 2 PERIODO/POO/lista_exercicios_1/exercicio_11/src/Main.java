public class Main {
    public static void main(String[] args) {
        Data dataAtual = new Data();
        System.out.println("DATA DE HOJE:\nDia: " + dataAtual.getDia() + "\nMes: " + dataAtual.getMes() + "\nAno: " + dataAtual.getAno());
        System.out.println("Data completa: " + dataAtual.getDataCompleta());

        Data dataPersonalizada = new Data("27","02","2023");
        System.out.println("\nDATA PERSONALIZADA:\nDia: " + dataPersonalizada.getDia() + "\nMes: " + dataPersonalizada.getMes() + "\nAno: " + dataPersonalizada.getAno());
        System.out.println("Data completa: " + dataPersonalizada.getDataCompleta());
    }
}