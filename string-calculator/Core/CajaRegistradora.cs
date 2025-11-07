namespace Core;

public class CajaRegistradora
{
    public decimal ValorAPagar { get; private set; } = 0;

    public void RegistrarProducto(Producto precio)
    {
        ValorAPagar += precio.I;
    }
}
public class Producto
{
    public string CepilloDental { get; }
    public int I { get; }

    public Producto(string cepilloDental, int i)
    {
        CepilloDental = cepilloDental;
        I = i;
    }
}