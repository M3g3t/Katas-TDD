using Core.SuperMarket;

namespace StringCalculator;

public class Descuento
{
    private decimal _porcentaje = 0;

    public Descuento(TipoProducto tipoProducto, decimal porcentaje)
    {
        _porcentaje = porcentaje;
    }

    public decimal ObtenerPorcentaje()
    {
        return _porcentaje / 100;
    }
}