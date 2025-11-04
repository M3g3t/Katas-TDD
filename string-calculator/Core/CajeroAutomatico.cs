namespace Core.Tests;

public class DetalleUnidad
{
    public TipoUnidad Tipo { get; set; }
    public int? Cantidad { get; set; }
}

public enum TipoUnidad
{
    Billete,
    Moneda
}

public class CajeroAutomatico
{
    private int _dineroDisponible { get; set; } = 5100;
    private int _dineroARetirar { get; set; } = 0;
    private List<string> _mensajesUnidadesRetiradas { get; set; } = new();
    private Dictionary<int, DetalleUnidad> _unidadesRetiradas { get; set; } = new();

    private static Dictionary<int, DetalleUnidad> _unidades = new()
    {
        { 500, new() { Tipo = TipoUnidad.Billete } },
        { 200, new() { Tipo = TipoUnidad.Billete } },
        { 100, new() { Tipo = TipoUnidad.Billete } },
        { 50, new() { Tipo = TipoUnidad.Billete } },
        { 20, new() { Tipo = TipoUnidad.Billete } },
        { 10, new() { Tipo = TipoUnidad.Billete } },
        { 5, new() { Tipo = TipoUnidad.Billete } },
        { 2, new() { Tipo = TipoUnidad.Moneda } },
        { 1, new() { Tipo = TipoUnidad.Moneda } }
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
                    AcomularDineroARetirar(unidad);
                    ActualizarSaldos(unidad.Key);
                    break;
                }
            }
        }

        AgregarMensajesUnidadesRetiradas();
        return _mensajesUnidadesRetiradas;
    }

    private void AcomularDineroARetirar(KeyValuePair<int, DetalleUnidad> unidad)
    {
        if (_unidadesRetiradas.TryGetValue(unidad.Key, out DetalleUnidad? detalle))
            detalle.Cantidad++;
        else
            _unidadesRetiradas[unidad.Key] = new() { Tipo = unidad.Value.Tipo, Cantidad = 1 };
    }

    private void AgregarMensajesUnidadesRetiradas()
    {
        foreach (var unidadRetirada in _unidadesRetiradas)
        {
            DetalleUnidad detalle = unidadRetirada.Value;
            string letraPlural = detalle.Cantidad > 1 ? "s" : string.Empty;
            string tipoUnidad = $"{(detalle.Tipo.Equals(TipoUnidad.Moneda) ? "moneda" : "billete")}{letraPlural}";
            _mensajesUnidadesRetiradas.Add($"{detalle.Cantidad} {tipoUnidad} de valor {unidadRetirada.Key}");
        }
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