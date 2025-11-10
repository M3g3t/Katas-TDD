using StringCalculator;

namespace Core.SuperMarket;

public class CajaRegistradora
{
    private readonly Descuento? _descuento;


    public CajaRegistradora(Descuento descuento)
    {
        _descuento = descuento;
    }

    public CajaRegistradora()
    {
    }

    public decimal ValorAPagar { get; private set; } = 0;

    public void RegistrarProducto(Producto producto)
    {
        ValorAPagar += CalcularPrecioProducto(producto.Precio);
    }

    private decimal CalcularPrecioProducto(decimal precio)
    {
        return precio - (_descuento?.ObtenerPorcentaje() ?? 0) * precio;
    }
}