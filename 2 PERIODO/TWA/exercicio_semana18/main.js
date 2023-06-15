import { Produto } from './produto.js';

async function carregaInformacoes(idInput, qtdInput) {
	
  try {
	let valido = false;
    const response = await fetch('./produtos.json');
    const data = await response.json().then((produtos) => {

		produtos.map((produto) => {
			if(produto.id == idInput){
				let p = new Produto(produto.id, produto.nome, produto.preco, qtdInput)
				arrayProdutos.push(p);
				valido = true;
				console.log(produto)
			}
		})
    });

	if(!valido) { 
		alert("Id inválido!");
	}

  } catch (error) {
	throw new Error('Erro ao carregar informações do produto');
  }
}


function criarProduto(event) {
	
  event.preventDefault();

  const idInput = document.getElementById('id');
  const qtdInput = document.getElementById('qtd');

  const id = idInput.value.trim();
  const qtd = Number(qtdInput.value);


  if(idInput.value == "" || qtdInput.value == "" ){
	alert("Campos vazios, preencha-os e tente novamente.");
  } 
  else if(qtd < 0) {
	alert("A quantidade não pode ser um valor negativo!");
  }
  else {
	carregaInformacoes(id,qtd);
  }
  

  // Limpa os campos do formulário
  idInput.value = '';
  qtdInput.value = '';

  console.log(arrayProdutos);
}

function gerarRelatorio(event) {
	let precoTotal = 0.0;
	let qtdTotal = 0;

	event.preventDefault();
  
	const result = document.getElementById('resultadoRelatorio');

	
	arrayProdutos.forEach((prod) => {
		result.innerHTML += `<p>Produto Nome: ${prod.nome} - Preço: ${prod.preco} - Total: ${prod.quantidade}</p>`;
		precoTotal += parseFloat(prod.preco);
		qtdTotal += Number(prod.quantidade);
	});

	result.innerHTML += `<br><p>Quantidade total: ${qtdTotal} - Preço Total: R$${precoTotal}</p>`;
  
	console.log(arrayProdutos)

}



let arrayProdutos = [];

const criar = document.getElementById('formulario');
criar.addEventListener('submit', criarProduto);

const relatorio = document.getElementById('relatorio')
relatorio.addEventListener('click', gerarRelatorio);
