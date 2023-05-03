class Usuario{
    #email
    #senha

    constructor(email,senha){
        this.#email = email;
        this.#senha = senha;
    };

    get email(){
        return this.#email;
    }

    set email(email){
        this.#email = email;
    }

    get senha(){
        return this.#senha;
    }

    set senha(senha){
        this.#senha = senha;
    }

    isAdmin(){
        if(this.admin){
            return true;
        }

        return false;
    }
}