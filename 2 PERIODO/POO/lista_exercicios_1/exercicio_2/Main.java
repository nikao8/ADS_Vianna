import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
         Scanner sc = new Scanner(System.in);
         
         Numeros num = new Numeros();
         
         System.out.println("Insira o primeiro valor: ");
         num.setInicial(sc.nextInt());
         
        System.out.println("Insira o segundo valor: ");
        num.setFinal(sc.nextInt());
        
        int[] numerosPares = num.paresIntervalo();
        
        for(int i = 0; i < numerosPares.length; i++)
        {
            System.out.print(numerosPares[i] + ", ");
        }
         
    }
}
