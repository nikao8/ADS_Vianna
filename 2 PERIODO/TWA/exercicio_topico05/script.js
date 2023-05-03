let anos_copa = [1952,1962,1970,1994,2002];

for(let i = 0; i < anos_copa.length; i++)
{
    console.log("O brasil ganhou a copa do ano de: " + anos_copa[i]);
}

let frutas = ['Banana', 'Maçã', 'Pera', 'Uva', 'Melância'];

for(let i = 0; i < frutas.length; i++)
{
    if(frutas[i].toLowerCase() == 'pera')
    {
        break;
    }
    console.log(frutas[i]);
}

