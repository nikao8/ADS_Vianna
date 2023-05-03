import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Triangulo triangulo = new Triangulo();
        Scanner sc = new Scanner(System.in);

        System.out.println("Insira o primeiro lado do triangulo: ");
        triangulo.setLado1(sc.nextInt());

        System.out.println("Insira o segundo lado do triangulo: ");
        triangulo.setLado2(sc.nextInt());

        System.out.println("Insira o terceiro lado do triangulo: ");
        triangulo.setLado3(sc.nextInt());

        sc.close();

        System.out.println("O triangulo é: " + triangulo.verificaTipoTriangulo());

    }


}
