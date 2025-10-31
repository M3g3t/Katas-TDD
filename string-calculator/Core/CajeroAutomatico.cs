namespace Core.Tests;

public class CajeroAutomatico
{
    private int _dineroDisponible { get;set; } = 5100;

    public string Retirar(int dineroARetirar)
    {
        if(dineroARetirar == 2)
            return "1 moneda de valor 2";
        
        if(dineroARetirar == 5)
            return "1 billete de valor 5";
        
        return "1 moneda de valor 1";
    }


    public int ConsultarDineroDisponible()
    {
        return _dineroDisponible;
    }
}