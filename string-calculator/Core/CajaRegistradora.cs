using StringCalculator;

namespace Core.SuperMarket;

public class CajaRegistradora
{
    private readonly Descuento[]? _descuentos;
    public decimal ValorAPagar { get; private set; } = 0;


    public CajaRegistradora(Descuento[] descuentos)
    {
        _descuentos = descuentos;
    }

    public CajaRegistradora()
    {
    }


    public void RegistrarProducto(Producto producto)
    {
        ValorAPagar += CalcularPrecioProducto(producto);
    }

    private decimal CalcularPrecioProducto(Producto producto)
    {
        return producto.Precio - (ObtenerDescuentoProducto(producto)?.ObtenerPorcentaje() ?? 0) * producto.Precio;
    }

    private Descuento? ObtenerDescuentoProducto(Producto producto)
    {
        return _descuentos?.FirstOrDefault(d => d.TipoProducto == producto.Tipo);
    }
}