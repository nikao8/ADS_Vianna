export class Drink {
      constructor(id, nome, instrucao, img) {
        this._id = id;
        this._nome = nome;
        this._instrucao = instrucao;
        this._img = img;
    }
        
    // Getters e setters
    get id() {
        return this._id;
    }
    
    set id(value) {
        this._id = value;
    }
    
    get nome() {
        return this._nome;
    }
    
    set nome(value) {
        this._nome = value;
    }

    get instrucao(){
        return this._instrucao;
    }

    set instrucao(value){
        this._instrucao = value;
    }

    get img(){
        return this._img;
    }

    set img(value){
        this._img = value;
    }
}
