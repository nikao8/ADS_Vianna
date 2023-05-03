public class Main
{
   public static void main (String args[]){
        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();
        Universidade uni1 = new Universidade();
        Universidade uni2 = new Universidade();
        
        uni1.setNome("Princeton");
        uni2.setNome("Cambridge");
        
        p1.setNome("Albert Einstein");
        p2.setNome("Isaac Newton");
        
        p1.setUniversidade(uni1);
        p2.setUniversidade(uni2);
        
        System.out.println(p1.retornaFrase());
        System.out.println(p2.retornaFrase());
    }
}
