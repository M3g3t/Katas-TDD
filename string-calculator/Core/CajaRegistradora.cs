namespace Core.SuperMarket;

public class CajaRegistradora
{
    public decimal ValorAPagar { get; private set; } = 0;

    public void RegistrarProducto(Producto producto)
    {
        if(producto.Nombre == "Crema Dental")
            ValorAPagar += producto.Precio / 2;
        else 
            ValorAPagar += producto.Precio;
    }
}
