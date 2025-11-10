using Core.SuperMarket;

namespace StringCalculator;

public class Descuento
{
    public decimal PorcentajeDescuento { get; }

    public Descuento(TipoProducto arroz, decimal porcentajeDescuento)
    {
        PorcentajeDescuento = porcentajeDescuento;
    }
}