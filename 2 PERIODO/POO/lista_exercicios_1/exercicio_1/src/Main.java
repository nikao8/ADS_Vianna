import ex1.*;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Pontos ponto = new Pontos();

        System.out.println("Insira o valor de xA e yA respectivamente");
        ponto.setxA(sc.nextDouble());
        ponto.setyA(sc.nextDouble());

        System.out.println("Insira o valor de xB e yB respectivamente");
        ponto.setxB(sc.nextDouble());
        ponto.setyB(sc.nextDouble());


        System.out.println("Distancia entre os pontos inseridos: " + ponto.CalculaDistanciaPontos());
    }
}