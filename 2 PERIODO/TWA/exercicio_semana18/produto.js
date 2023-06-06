export class Produto {
    constructor(id, nome, preco, quantidade) {
      this._id = id;
      this._nome = nome;
      this._preco = preco;
      this._quantidade = quantidade;
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
  
    get preco() {
      return this._preco;
    }
  
    set preco(value) {
      this._preco = value;
    }
  
    get quantidade() {
      return this._quantidade;
    }
  
    set quantidade(value) {
      this._quantidade = value;
    }
  }