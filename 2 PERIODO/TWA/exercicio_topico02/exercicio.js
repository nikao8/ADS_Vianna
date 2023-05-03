// Aluno: Nicolas Marques Pacheco

/*
- Declare uma variável contendo uma string 
- Declare uma variável contendo um número dentro de uma string
- Declare uma variável com a sua idade 
- Declare outra variável para contar a frase: Meu nome é SEU NOME e minha idade é SUA IDADE
- Declare  outras duas variáveis, uma  com seu sobrenome e com seu nome exiba as mesmas juntas
- Coloque a seguinte frase em uma variável: It's study  time
- Verifique o tipo da variável que contém o seu nome
*/


//- Declare uma variável contendo uma string 
let texto = "teste";

//- Declare uma variável contendo um número dentro de uma string
let numString = "8";

//- Declare uma variável com a sua idade
let idade = 21;

//- Declare outra variável para contar a frase: Meu nome é SEU NOME e minha idade é SUA IDADE
let nome = "Nicolas";
let apresentacao = "Meu nome é " + nome + ", e minha idade é " + idade + " anos";

//- Declare  outras duas variáveis, uma  com seu sobrenome e com seu nome exiba as mesmas juntas
let sobrenome = "Marques Pacheco";
console.log(nome + " " + sobrenome);

//- Coloque a seguinte frase em uma variável: It's study time
texto = "It's study time";

//- Verifique o tipo da variável que contém o seu nome
console.log(typeof(nome));

/*
Verifique se a sua idade é maior do que a de algum parente
Dependendo do resultado coloque no console 'É maior', 'É igual */
var idade2 = 19;
var idade3 = 43;

if (idade2 > idade3) {
    console.log("Luís é mais velho que Fulano");
}

else if (idade2 = idade3) {
    console.log("Nicolas possui a mesma idade que a de fulano");
}
else {
    console.log("Fulano é mais velho que Nicolas");
}

/* Qual valor é retornado na seguinte expressão? */  
var expressao = (5 - 2) && (5 - ' ') && (5 - 2);
console.log(expressao);

Verifique se as seguintes variáveis são True ou False
var nome = 'João'; //true
var idade = 28; //true
var possuiDoutorado = false; //false
var empregoFuturo; //false
var dinheiroNaConta = 0; //false

/* Compare o total de habitantes do Brasil com China (valor em mi)  
var brasil = 207; var china = 1340; */

var brasil = 207;
var china = 1340;
var diferenca = china - brasil;

if (brasil < china) {
    console.log("A China tem " + diferenca + " milhões de habitantes a mais que o Brasil")
}
else {
    console.log("O Brasil tem " + diferenca + " milhões de habitantes a mais que a China")
}



/* O que irá aparecer no console ?
if (('Gato' === 'gato') && (5 > 2)) {
    console.log('Verdadeiro');
} else {
    console.log('Falso');
} 
*/
falso



/*
O que irá aparecer no console ? 
if (('Gato' === 'gato') || (5 > 2)) {
console.log('Gato' && 'Cão');
} else {
console.log('Falso');
}
*/
Cão

/*
Some 500 ao valor de scroll abaixo, atribuindo o novo valor a scroll  
var scroll = 1000; 
Atribua true para a variável darCredito, caso o cliente possua carro e casa e false caso o contrário.
var possuiCarro = true; var possuiCasa = true; var darCredito;  
*/

var scroll = 1000;
scroll += 500;
var darCredito;
var carro = true;
var possuiCasa = true;
if((clinte == possuiCasa) && (clinte == carro))
{
    darCredito = true;
}
else
    darCredito = false;

// Functions 
function Somar(a,b)
{
    return a + b;
}

function Subtracao(a,b)
{
    return a - b;
}

function Multiplicacao(a,b)
{
    return a * b;
}

function Divisao(a,b)
{
    return a / b;
}

function Operacao(funcao,a,b)
{
    var result = funcao(a,b);
    console.log(result);
}
//////////////////////////////////////////
