namespace Core.Tests;

public class CajeroAutomatico
{
    private int _dineroDisponible { get; set; } = 5100;
    private int _dineroARetirar { get; set; } = 0;
    private List<string> _unidadesRetiradas { get; set; } = new();

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
        _dineroARetirar = dineroARetirar;
        return ProcesarDineroARetirar();
    }

    private void ActualizarSaldos(int dineroARetirar)
    {
        _dineroDisponible -= dineroARetirar;
        _dineroARetirar -= dineroARetirar;
    }

    private List<string> ProcesarDineroARetirar()
    {
        while (_dineroARetirar is not 0)
        {
            foreach (var unidad in _unidades)
            {
                if (HayDineroPorRetirar(_dineroARetirar, unidad.Key))
                {
                    AgregarUnidadesRetiradas(unidad.Value);
                    ActualizarSaldos(unidad.Key);
                }
            }
        }

        return _unidadesRetiradas;
    }

    private void AgregarUnidadesRetiradas(string unidadRetirada)
    {
        _unidadesRetiradas.Add(unidadRetirada);
    }

    private static bool HayDineroPorRetirar(int dineroARetirar, int unidad)
    {
        return dineroARetirar > unidad || dineroARetirar == unidad;
    }


    public int ConsultarDineroDisponible()
    {
        return _dineroDisponible;
    }
}