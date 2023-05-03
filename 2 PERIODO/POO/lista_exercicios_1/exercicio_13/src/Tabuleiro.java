public class Tabuleiro {
    private int[][] tabuleiro;
    private int nJogada;

    public Tabuleiro(){
        tabuleiro = new int[3][3];
        zerarTabuleiro();
        nJogada = 0;

    }

    public void realizaJogada(int linha, int coluna,int simbolo){
        if(tabuleiro[linha][coluna] == 0){
            tabuleiro[linha][coluna] = simbolo;
            setnJogada();
        }
    }

    public int verificaLinha(){
        for (int i = 0; i < 3 ; i++){
            if(tabuleiro[i][0] + tabuleiro[i][1] + tabuleiro[i][2] == 3){
                return 1;
            }

            if(tabuleiro[i][0] + tabuleiro[i][1] + tabuleiro[i][2] == -3){
                return -1;
            }
        }
        return 0;
    }

    public int verificaColuna(){
        for (int i = 0; i < 3 ; i++){
            if( (tabuleiro[0][i] + tabuleiro[1][i] + tabuleiro[2][i]) == 3){
                return 1;
            }

            if( (tabuleiro[0][i] + tabuleiro[1][i] + tabuleiro[2][i]) == -3){
                return -1;
            }
        }
        return 0;
    }

    public int verificaDiagonal(){
        for(int i = 0; i < 3; i++){
            if( (tabuleiro[0][0] + tabuleiro[1][1] + tabuleiro[2][2]) == 3){
                return 1;
            }

            if( (tabuleiro[0][0] + tabuleiro[1][1] + tabuleiro[2][2]) == -3){
                return -1;
            }

            if( (tabuleiro[0][2] + tabuleiro[1][1] + tabuleiro[2][0]) == 3){
                return 1;
            }

            if( (tabuleiro[0][2] + tabuleiro[1][1] + tabuleiro[2][0]) == -3){
                return -1;
            }
        }
        return 0;
    }

    public void zerarTabuleiro(){
        for(int linha=0 ; linha<3 ; linha++){
            for(int coluna=0 ; coluna<3 ; coluna++){
                tabuleiro[linha][coluna]=0;
            }
        }
    }

    public void exibeTabuleiro(){
        for(int linha=0 ; linha<3 ; linha++){
            for(int coluna=0 ; coluna<3 ; coluna++){

                if(tabuleiro[linha][coluna]==1){
                    System.out.print(" X ");
                }
                if(tabuleiro[linha][coluna]==-1){
                    System.out.print(" O ");
                }
                if(tabuleiro[linha][coluna]==0){
                    System.out.print("   ");
                }

                if(coluna==0 || coluna==1)
                    System.out.print("|");
            }
            System.out.println();
        }
    }

    public int getnJogada() {
        return nJogada;
    }

    public void setnJogada() {
        this.nJogada++;
    }
}
