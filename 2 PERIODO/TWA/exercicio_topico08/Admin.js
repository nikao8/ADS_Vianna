class Admin extends Usuario{
    constructor(email,senha){
        super(email,senha);
        this.admin = true;
    }
}