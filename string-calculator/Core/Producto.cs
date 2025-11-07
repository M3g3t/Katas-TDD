namespace Core.SuperMarket;

public class Producto
{
    public string Nombre { get; }
    public int Precio { get; }

    public Producto(string nombre, int precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}