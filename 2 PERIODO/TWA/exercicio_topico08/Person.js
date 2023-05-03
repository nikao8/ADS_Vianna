class Person{

    #nome;

    constructor(primeiro, ultimo, idade, genero, interesses){
        this.#nome = {
            primeiro,ultimo
        };

        this._idade = idade;
        this._genero = genero;
        this._interesses = interesses;
    }

    cumprimentar(){
        console.log(`Olá! meu nome é ${this.#nome.primeiro}`);
    };

    despedir(){
        console.log(`${this.#nome.primeiro} se despediu!`);
    }

    get nome(){
        return this.#nome;
    }


    get primeiro(){
        return this.#nome.primeiro;
    }

    set primeiro(primeiro){
        this.#nome.primeiro = primeiro;
    }

    get ultimo(){
        return this.#nome.ultimo;
    }

    set ultimo(ultimo){
        this.#nome.ultimo = ultimo;
    }

}