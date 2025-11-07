namespace Core.SuperMarket;

public class Producto(string nombre, int precio)
{
    public string Nombre { get; } = nombre;
    public int Precio { get; } = precio;
}