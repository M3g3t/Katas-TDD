using Core.SuperMarket;

namespace StringCalculator;

public class Descuento
{
    private decimal _porcentaje = 0;
    public TipoProducto TipoProducto { get; set; }
    public Descuento(TipoProducto tipoProducto, decimal porcentaje)
    {
        _porcentaje = porcentaje;
        TipoProducto = tipoProducto;
    }

    public decimal ObtenerPorcentaje()
    {
        return _porcentaje / 100;
    }
}