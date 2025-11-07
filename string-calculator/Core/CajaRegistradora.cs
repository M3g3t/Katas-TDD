namespace Core.SuperMarket;

public class CajaRegistradora
{
    public decimal ValorAPagar { get; private set; } = 0;

    public void RegistrarProducto(Producto producto)
    {
        if(producto.Tipo == TipoProducto.CremaDental)
            ValorAPagar += producto.Precio / 2;
        else if(producto.Tipo == TipoProducto.Arroz)
            ValorAPagar +=   producto.Precio - ((10m / 100m) *  producto.Precio) ;
        else 
            ValorAPagar += producto.Precio;
    }
}
