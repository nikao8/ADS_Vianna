using System;

namespace FP02_48
{
    class Program
    {
        static void Main(string[] args)
        {

            int op;

            Console.WriteLine("Digite um numero para escolher o exercicio 1,2,3,4,5 e 6 ");
            op = Convert.ToInt32(Console.ReadLine());

            switch(op){

                case 1:
                    double temperatura, result;

                    Console.WriteLine("Informe a temperatura em Celcius: ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    result = (9 * temperatura + 160) / 5;

                    Console.WriteLine("O resultado da conversão é: {0}°F", result);

                    break;

                case 2:

                    double salarioMin, salarioFunc, resultado;

                    Console.WriteLine("Informe valor do salário mínimo: ");
                    salarioMin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe valor do salário do funcionário: ");
                    salarioFunc = Convert.ToDouble(Console.ReadLine());

                    resultado = salarioFunc / salarioMin;

                    Console.WriteLine("O resultado é: {0} salários mínimos", resultado);

                    break;

                case 3:

                    double lado, altura, perimetro, area;


                    Console.WriteLine("Informe o lado do triângulo: ");
                    lado = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Informe a altura do triângulo: ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    perimetro = lado + lado + lado + lado;
                    area = (lado * altura) / 2;

                    Console.WriteLine("O perímetro do triangulo é: {0}", perimetro);
                    Console.WriteLine("A área do triangulo é: {0}", area);

                break;

                case 4:
                    int num;

                    Console.WriteLine("Informe um numero: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Antessessor: {0}", num - 1);
                    Console.WriteLine("Sucessor: {0}", num + 1);
                break;

                case 5:
                    double valorProduto, desconto, res;

                    Console.WriteLine("Informe o valor do produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());

                    desconto = valorProduto * 0.25;
                    res = valorProduto - desconto;

                    Console.WriteLine("O valor com desconto é: R${0},00", res);

                break;

                case 6:
                    int totSeg, totSeg2, horas, min, seg;

                    Console.WriteLine("Informe os segundos: ");
                    totSeg = Convert.ToInt32(Console.ReadLine());

                    horas = totSeg / 3600;
                    totSeg2 = totSeg % 3600;
                    min = totSeg2 / 60;
                    seg = totSeg2 % 60;

                    Console.WriteLine("{0}s é igual a {1}h {2}m {3}s", totSeg, horas, min, seg);

                break;
            }
        }
    }
}
