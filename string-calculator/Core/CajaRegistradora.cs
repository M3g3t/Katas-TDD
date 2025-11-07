namespace Core;

public class CajaRegistradora
{
    public decimal ValorAPagar { get; private set; } = 0;

    public void RegistrarProducto(int precio)
    {
        ValorAPagar = 10;
    }
}