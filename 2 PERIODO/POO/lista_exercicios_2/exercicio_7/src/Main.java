public class Main {
    public static void main(String[] args) {
        TimeFutebol time = new TimeFutebol();
        time.setNome("São Paulo");
        time.setCidade("São Paulo");
        time.setEstado("SP");

        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();

        j1.setNome("Daniel Alves");
        j1.setPeso(71.0);
        j1.setNumero(10);
        j1.setPosicao(2);

        j2.setNome("Thiago Volpi");
        j2.setPeso(78.0);
        j2.setNumero(1);
        j2.setPosicao(0);

        time.addJogador(j1);
        time.addJogador(j2);
    }
}
