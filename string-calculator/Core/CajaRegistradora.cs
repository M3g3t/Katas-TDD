using StringCalculator;

namespace Core.SuperMarket;

public class CajaRegistradora
{
    private readonly Descuento[]? _descuentos;


    public CajaRegistradora(Descuento[] descuentos)
    {
        _descuentos = descuentos;
    }

    public CajaRegistradora()
    {
    }

    public decimal ValorAPagar { get; private set; } = 0;

    public void RegistrarProducto(Producto producto)
    {
        ValorAPagar += CalcularPrecioProducto(producto);
    }

    private decimal CalcularPrecioProducto(Producto producto)
    {
        var descuentoProducto = _descuentos?.FirstOrDefault(d => d.TipoProducto == producto.Tipo);
        
        return producto.Precio - (descuentoProducto?.ObtenerPorcentaje() ?? 0) * producto.Precio;
    }
}