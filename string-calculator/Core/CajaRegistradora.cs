namespace Core.SuperMarket;

public class CajaRegistradora
{
    public decimal ValorAPagar { get; private set; } = 0;

    public void RegistrarProducto(Producto producto)
    {
        ValorAPagar += producto.Precio;
    }
}
