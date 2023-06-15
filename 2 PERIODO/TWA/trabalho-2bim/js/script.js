import { Drink } from './Drink.js';

let arrayDrinks = [];
preencheArrayDrinks();

// primeira coluna
var gerador = document.getElementById("gerador");
var pesquisar = document.getElementById("pesquisar");
var txtBusca = document.getElementById("txtBusca");

var nome = document.getElementById("nome");
var imagem = document.getElementById("imagem");
var instrucoes = document.getElementById("instrucoes");

//segunda coluna
var nome2 = document.getElementById("nome2");
var imgPesquisa = document.getElementById("imgPesquisa");
var instrucoes2 = document.getElementById("instrucoes2");

//terceira coluna
var nome3 = document.getElementById("nome3");
var img3 = document.getElementById("img3");
var instrucoes3 = document.getElementById("instrucoes3");
var proximo = document.getElementById("proximo");
var anterior = document.getElementById("anterior");

let indice = 0;

function preencheColuna3(i){
    nome3.innerHTML = arrayDrinks[i].nome;

    img3.src = arrayDrinks[i].img;
    
    instrucoes3.innerHTML = arrayDrinks[i].instrucao;
}

proximo.addEventListener('click', () => {
    indice++;

    if(indice >= arrayDrinks.length){
        indice = 0;
    }

    preencheColuna3(indice);
})

anterior.addEventListener('click', () => {
    indice--;

    if(indice < 0){
        indice = arrayDrinks.length - 1;
    }

    preencheColuna3(indice);
})

gerador.addEventListener('click', () => {
    var aleatorio = Math.floor(Math.random() * 5)

    nome.innerHTML = arrayDrinks[aleatorio].nome

    imagem.src = arrayDrinks[aleatorio].img

    instrucoes.innerHTML = arrayDrinks[aleatorio].instrucao

})

pesquisar.addEventListener('click', (event) => {
    event.preventDefault()

    let found = false;
    
    for (var i = 0; i < arrayDrinks.length; i++) {
        if (txtBusca.value == arrayDrinks[i].nome) {
            var valor = i;
            found = true;
            break;
        }
    }

    if(!found){
        imgPesquisa.src = './img/no-results.png';
        nome2.innerHTML = 'Drink não encontrado';
        instrucoes2.innerHTML = '';
    }
    else
    {
        imgPesquisa.src = arrayDrinks[valor].img
        instrucoes2.innerHTML = arrayDrinks[valor].instrucao
        nome2.innerHTML = arrayDrinks[valor].nome
    }

})

async function preencheArrayDrinks() {
	
    try {
        const response = await fetch('https://www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita').then((response) => {
            response.json().then((dados) => {
                dados.drinks.map((drink) => {
                    let d = new Drink(drink.idDrink, drink.strDrink, drink.strInstructions, drink.strDrinkThumb);
                    arrayDrinks.push(d);
                })
            })
        });
    } catch (error) {
        throw new Error('Erro ao carregar informações da api');
    }

}
