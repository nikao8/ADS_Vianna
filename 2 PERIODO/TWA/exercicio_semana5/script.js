let contagem = prompt("Insira a quantidade de vezes que mariana vai contar:");

MarianaConta(contagem);

function MarianaConta(qtd)
{
    for(let i = 1; i <= qtd; i++)
    {
        console.log(`Mariana conta ${i}`);
        for(let j = 0; j < i; j++)
        {
            console.log(`Viva a mariana!`);
        }
    }
} 
