namespace Core.Tests;

public class CajeroAutomatico
{
    private int _dineroDisponible { get; set; } = 5100;

    public string Retirar(int dineroARetirar)
    {
        return ProcesarDineroARetirar(dineroARetirar);
    }

    private static string ProcesarDineroARetirar(int dineroARetirar)
        => dineroARetirar switch
        {
            2 => "1 moneda de valor 2",
            5 => "1 billete de valor 5",
            10 => "1 billete de valor 10",
            _ => "1 moneda de valor 1"
        };


    public int ConsultarDineroDisponible()
    {
        return _dineroDisponible;
    }
}