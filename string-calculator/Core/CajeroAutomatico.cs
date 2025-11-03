namespace Core.Tests;

public class CajeroAutomatico
{
    private int _dineroDisponible { get; set; } = 5100;

    private static Dictionary<int, string> _unidades = new()
    {
        { 500, "1 billete de valor 500" },
        { 200, "1 billete de valor 200" },
        { 100, "1 billete de valor 100" },
        { 50, "1 billete de valor 50" },
        { 20, "1 billete de valor 20" },
        { 10, "1 billete de valor 10" },
        { 5, "1 billete de valor 5" },
        { 2, "1 moneda de valor 2" },
        { 1, "1 moneda de valor 1" }
    };

    public List<string> Retirar(int dineroARetirar)
    {
        DescontarDineroDisponible(dineroARetirar);
        return ProcesarDineroARetirar(dineroARetirar);
    }

    private void DescontarDineroDisponible(int dineroARetirar)
    {
        _dineroDisponible -= dineroARetirar;
    }

    private static List<string> ProcesarDineroARetirar(int dineroARetirar)
    {
        List<string> unidadesRetiradas = new();
        while (dineroARetirar is not 0)
        {
            foreach (var unidad in _unidades)
            {
                if (dineroARetirar > unidad.Key || dineroARetirar == unidad.Key)
                {
                    unidadesRetiradas.Add(unidad.Value);
                    dineroARetirar -= unidad.Key;
                }
            }    
        }
        
        return unidadesRetiradas;
    }


    public int ConsultarDineroDisponible()
    {
        return _dineroDisponible;
    }
}