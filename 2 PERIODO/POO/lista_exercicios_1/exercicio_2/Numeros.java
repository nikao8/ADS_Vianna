
/**
 * Escreva uma descrição da classe Numeros aqui.
 * 
 * @author (seu nome) 
 * @version (um número da versão ou uma data)
 */
public class Numeros
{
  private int nInicial;
  private int nFinal;
  
  public Numeros(){
  }
  
  public int getInicial(){
      return nInicial;
  }
  
  public void setInicial(int nInicial)
  {
      this.nInicial = nInicial;
  }

    public int getFinal(){
      return nInicial;
  }
  
  public void setFinal(int nFinal)
  {
      this.nFinal = nFinal;
  }
  
  private int descobreMenor(int nInicial, int nFinal){
      if(nInicial < nFinal)
      {
          return nInicial;
      }
      return nFinal;
  }
  
  private int descobreMaior(int nInicial, int nFinal)
  {
      if(nInicial > nFinal)
      {
          return nInicial;
      }
      return nFinal;
  }
  
  public int[] paresIntervalo(){
      int qtdPares = 0;
      
      for(int i = descobreMenor(nInicial,nFinal); i <= descobreMaior(nInicial,nFinal); i++){
          if(i % 2 == 0)
          {
              qtdPares++;
          }
      }
      
      int[] pares = new int[qtdPares];
      int x = 0;
      
      for(int i = descobreMenor(nInicial,nFinal); i <= descobreMaior(nInicial,nFinal); i++){
          if(i % 2 == 0)
          {
              pares[x] = i;
              x++;
          }
      }
      
      return pares; 
  }
  
    
}
