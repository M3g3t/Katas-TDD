namespace Core.Tests;

public class CajeroAutomatico
{
    private int _dineroDisponible { get; set; } = 5100;

    public string Retirar(int dineroARetirar)
    {
        DescontarDineroDisponible(dineroARetirar);
        return ProcesarDineroARetirar(dineroARetirar);
    }

    private void DescontarDineroDisponible(int dineroARetirar)
    {
        _dineroDisponible -= dineroARetirar;
    }

    private static string ProcesarDineroARetirar(int dineroARetirar)
        => dineroARetirar switch
        {
            2 => "1 moneda de valor 2",
            5 => "1 billete de valor 5",
            10 => "1 billete de valor 10",
            20 => "1 billete de valor 20",
            50 => "1 billete de valor 50",
            100 => "1 billete de valor 100",
            200 => "1 billete de valor 200",
            500 => "1 billete de valor 500",
            _ => "1 moneda de valor 1"
        };


    public int ConsultarDineroDisponible()
    {
        return _dineroDisponible;
    }
}