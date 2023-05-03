import java.util.ArrayList;

public class Condominio
{
    private String nome;
    private String endereco;
    private ArrayList<Despesa> despesas;
    private ArrayList<Imovel> imoveis;
    private ArrayList<Pagamento> pagamentos;
    
    public Condominio(){
        despesas = new ArrayList<Despesa>();
        imoveis = new ArrayList<Imovel>();
        pagamentos = new ArrayList<Pagamento>();
    }
    
    public Condominio(String nome, String endereco){
        this.nome = nome;
        this.endereco = endereco;
        despesas = new ArrayList<Despesa>();
        imoveis = new ArrayList<Imovel>();
        pagamentos = new ArrayList<Pagamento>();
    }
    
    public double valorCondominio(int mesAno){
        double valorDespesasTotal = 0;
        
        for(Despesa desp : despesas){
            if(desp.getMesAno() == mesAno){
                valorDespesasTotal += desp.getValor();    
            }
        }
        
        return valorDespesasTotal / imoveis.size();
    }
    
    private int totalPago(int mesAno){
        int totPago = 0;
        for(Pagamento pag : pagamentos){
            if(pag.getMesAno() == mesAno){
                totPago += pag.getValorPago();
            }
        }
        return totPago;
    }
    
    public String relatorio(){
        int mes = 1;
        String resultado = "";
        
        resultado += "Mês: " + mes + " - 2023";
        int totPg = totalPago(Integer.parseInt(mes + "2023"));
        resultado += imoveis.size() + " apartamentos ("+ totPg +" pagos) - " + (imoveis.size() - totPg) + " não pagos";
        resultado += "Valor arrecadado: R$ " + (totPg * valorCondominio(Integer.parseInt(mes + "2023"))) + "R$ " + ((imoveis.size() - totPg) * valorCondominio(Integer.parseInt(mes + "2023"))) ;
        
        return resultado;
    }
    
    public void pagarCondominio(Imovel imovel, int mesAno){
        Pagamento p = new Pagamento(mesAno, valorCondominio(mesAno), imovel, this);
        
        /*  CASO NAO USASSE O CONSTRUTOR DE PAGAMENTO VAZIO, TERIA QUE SER FEITO:
               
            Pagamento p = new Pagamento();
            p.setMesAno(mesAno);
            p.setValor(valorCondominio(mesAno));
            p.setImovel(imovel);
            p.setCondominio(this);
        */
        
        pagamentos.add(p);
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public String getNome(){
        return nome;
    }
    
    public void setEndereco(String endereco){
        this.endereco = endereco;
    }
    
    public String getEndereco(){
        return endereco;
    }
    
    public ArrayList<Despesa> getDespesas(){
        return despesas;
    }
    
    public void addDespesa(Despesa desp){
        this.despesas.add(desp);
    }
    
    public ArrayList<Imovel> getImoveis(){
        return imoveis;
    }
    
    public void addImovel(Imovel imovel){
        this.imoveis.add(imovel);
    }
    
    public ArrayList<Pagamento> getPagamentos(){
        return pagamentos;
    }
    
    public void addPagamento(Pagamento pagamento){
        this.pagamentos.add(pagamento);
    }
    
}
