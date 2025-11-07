namespace Core;

public class CajaRegistradora
{
    public decimal ValorRegistrado { get; private set; } = 0;

    public void RegistrarProducto(int i)
    {
        ValorRegistrado = 10;
    }
}