
public class Funcionario
{
    //Atributos;
    private String nome;
    private int numeroFilhos;
    private double salarioBruto;
    boolean usaValeTransporte, ehTrabalhadorNoturno;
    
    //Metodos de Acesso
    //Set serve para alterar
    public void setNumeroFilhos(int novoNumeroFilho){
        if (novoNumeroFilho >= 0){
            numeroFilhos = novoNumeroFilho;
        }        
    }       
    //Get Serve para exibir o valor de uma atributo private
    public int getNumeroFilhos(){
        return numeroFilhos;
    }
    
    public void setNome(String nome){
        if (nome != null && !nome.equals("") ){
            this.nome = nome;
        }
    }
    public String getNome(){
        return nome;
    }
    
    
    public void setSalarioBruto(double salarioBruto){
        if ( salarioBruto >=0 && 
        salarioBruto >= this.salarioBruto ){
            this.salarioBruto = salarioBruto;
        }
    }
    public double getSalarioBruto(){
        return salarioBruto;
    }
    
    //Metodo Construtor
    public Funcionario(){        
    }
    public Funcionario(String nome, int numeroFilhos,
    double salarioBruto, boolean usaValeTransporte, 
    boolean ehTrabalhadorNoturno ){ 
        this.nome = nome;
        this.numeroFilhos = numeroFilhos;
        this.salarioBruto = salarioBruto;
        this.usaValeTransporte = usaValeTransporte;
        this.ehTrabalhadorNoturno = ehTrabalhadorNoturno;
        
    }
    
    //Metodo    
    private double inss(){
        return salarioBruto * 0.13;
    }
    private double descontoValeTransporte(){
        if (usaValeTransporte)
          return salarioBruto * 0.06;
        else  
          return 0;
    }
    private double bonusNoturno(){
        return (ehTrabalhadorNoturno)? salarioBruto * 0.05: 0;
    }
    private double bonusPorFilho(){
        return (numeroFilhos <=3 )? numeroFilhos*50 : 150;
    }
    
    public double salarioLiquido(){
        
        return salarioBruto - inss() - descontoValeTransporte() 
         + bonusNoturno() + bonusPorFilho();
        
        /*double salPArc = (salarioBruto * 0.87);
        if (usaValeTransporte){
            salPArc -= (salarioBruto * 0.06);
        }
        salPArc += (ehTrabalhadorNoturno)? salarioBruto * 0.05: 0;
        
        salPArc += (numeroFilhos <=3 )? numeroFilhos*50 : 150;       
        
        return salPArc;*/
    }
    
}
