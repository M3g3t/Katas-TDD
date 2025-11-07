namespace Core.SuperMarket;

public class Producto(TipoProducto tipo, int precio)
{
    public TipoProducto Tipo { get; } = tipo;
    public int Precio { get; } = precio;
}