import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;
import java.time.format.ResolverStyle;

public class Data {

    private String dia;
    private String mes;
    private String ano;
    private String dataCompleta;
    //2021-12-17
    public Data(){
        String tempDate = java.time.LocalDate.now().toString();

        this.ano = tempDate.substring(0,4);
        this.mes = tempDate.substring(5,7);
        this.dia = tempDate.substring(8,10);

        this.dataCompleta = dia + "/" + mes + "/" + ano;
    }

    public Data(String dia, String mes, String ano){
        //String tempDate = ano + "-" + mes + "-" + dia;
        String tempDate1 = dia + "/" + mes + "/" + ano;


        dataCompleta = tempDate1;
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;

        /*
        if(isValid(tempDate)){
            dataCompleta = tempDate1;
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        else {
            dataCompleta = "A data " + tempDate1 + " é uma data inválida";
        }*/
    }
    /*
    public static boolean isValid(String strDate) { // Não funciona 100%...
        String dateFormat = "dd/MM/uuuu";

        DateTimeFormatter dateTimeFormatter = DateTimeFormatter.ofPattern(dateFormat).withResolverStyle(ResolverStyle.STRICT);
        try {
            LocalDate date = LocalDate.parse(strDate, dateTimeFormatter);
            return true;
        } catch (DateTimeParseException e) {
            return false;
        }
    }*/

    public String getDia() {
        return dia;
    }

    public void setDia(String dia) {
        this.dia = dia;
    }

    public String getMes() {
        return mes;
    }

    public void setMes(String mes) {
        this.mes = mes;
    }

    public String getAno() {
        return ano;
    }

    public void setAno(String ano) {
        this.ano = ano;
    }

    public String getDataCompleta() {
        return dataCompleta;
    }

    public void setDataCompleta(String dataCompleta) {
        this.dataCompleta = dataCompleta;
    }
}
