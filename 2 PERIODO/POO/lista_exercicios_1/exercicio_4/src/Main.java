import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Consumidor consumidor =  new Consumidor();
        Carro carro = new Carro();

        System.out.println("### CALCULO IMPOSTOS E ADICIONAIS DE VEICULO. ###");
        cadastraConsumidor(consumidor);
        cadastraInformacoesCarro(carro,consumidor);
        carro.calculaPrecoFinal();
        consumidor.setCarro(carro);
        retornaInformacoes(consumidor,carro);

    }

    public static void cadastraConsumidor(Consumidor consumidor){
        Scanner sc = new Scanner(System.in);
        System.out.println("## CADASTRO DO CLIENTE ##");

        System.out.println("# Insira seu nome: ");
        consumidor.setNome(sc.next());

        System.out.println("# Insira seu cpf: ");
        consumidor.setCpf(sc.next());
    }

    public static void cadastraInformacoesCarro(Carro carro, Consumidor consumidor){
        Scanner sc = new Scanner(System.in);

        System.out.println("## PREENCHA AS INFORMAÇÕES DO VEICULO: ");

        System.out.println("# Insira o valor bruto do carro: ");
        carro.setPreco(sc.nextDouble());

        System.out.println("# Qual a potencia do motor?: ");
        carro.setPotencia_motor(sc.nextDouble());

        System.out.println("# O carro possui ar condicionado? (s para sim, n para não): ");
        carro.setAr_condicionado(sc.next().toLowerCase().equals("s") ? true : false );

        System.out.println("# O carro possui cambio automatico? (s para sim, n para não): ");
        carro.setCambio_automatico(sc.next().toLowerCase().equals("s") ? true : false );

        System.out.println("# O carro possui alarme? (s para sim, n para não): ");
        carro.setAlarme(sc.next().toLowerCase().equals("s") ? true : false );

        System.out.println("# O carro possui pintura especial? (s para sim, n para não): ");
        carro.setPintura_especial(sc.next().toLowerCase().equals("s") ? true : false );

        System.out.println("# O carro possui teto solar? (s para sim, n para não): ");
        carro.setTeto_solar(sc.next().toLowerCase().equals("s") ? true : false );

        System.out.println("# O carro possui kit multimidia? (s para sim, n para não): ");
        carro.setKit_multimidia(sc.next().toLowerCase().equals("s") ? true : false );

    }


    public static void retornaInformacoes(Consumidor consumidor, Carro carro){
        System.out.println("Olá " + consumidor.getNome() + ", segue as informações do seu carro!");
        System.out.println("Potencia do motor: " + carro.getPotencia_motor());
        System.out.println("Possui ar condicionado?: " + carro.isAr_condicionado());
        System.out.println("Possui cambio automatico?: " + carro.isCambio_automatico());
        System.out.println("Possui alarme?: " + carro.isAlarme());
        System.out.println("Possui pintura especial?: " + carro.isPintura_especial());
        System.out.println("Possui teto solar?: " + carro.isTeto_solar());
        System.out.println("Possui kit multimidia?: " + carro.isKit_multimidia());
        System.out.println("\nO preço final do carro é: R$?: " + carro.getPreco());
    }

}