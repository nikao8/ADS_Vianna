import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Jogo jogo = new Jogo();
        Scanner sc = new Scanner(System.in);

        while(jogo.verificaTermino() == 0) {
            jogadaJogador(jogo,jogo.getJogador1(),1);
            jogadaJogador(jogo,jogo.getJogador2(),2);
        }

        jogo.getTabuleiro().exibeTabuleiro();

        if(jogo.getJogador1().isVencedor()){
            System.out.println("Jogador [1] é o vencedor.");
        }

        if(jogo.getJogador2().isVencedor()){
            System.out.println("Jogador [2] é o vencedor.");
        }

        if(jogo.verificaTermino() == 2){
            System.out.println("# Empate #.");
        }
    }

    public static void jogadaJogador(Jogo jogo, Jogador jogador,int numJogador){
        Scanner sc = new Scanner(System.in);

        if(jogo.verificaTermino() == 0){
            System.out.println("\nJogador ["+ numJogador +"] é a sua vez de jogar: " );
            jogo.getTabuleiro().exibeTabuleiro();

            int linha1, coluna1;
            System.out.print("Insira a linha da jogada (0-2):");
            linha1 = sc.nextInt();
            System.out.print("Insira a coluna da jogada (0-2):");
            coluna1 = sc.nextInt();

            jogo.getTabuleiro().realizaJogada(linha1,coluna1,jogador.getSimbolo());
        }
    }

}