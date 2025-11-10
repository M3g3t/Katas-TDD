using StringCalculator;

namespace Core.SuperMarket;

public class CajaRegistradora
{
    private readonly Descuento _descuento;


    public CajaRegistradora(Descuento descuento)
    {
        _descuento = descuento;
    }
    public CajaRegistradora()
    {
        
    }

    public decimal ValorAPagar { get; private set; } = 0;

    public void RegistrarProducto(Producto producto)
    {
        if(producto.Tipo == TipoProducto.CremaDental)
            ValorAPagar += producto.Precio / 2;
        else if (producto.Tipo == TipoProducto.Arroz)
        {
            
            ValorAPagar +=   producto.Precio -  (_descuento?.PorcentajeDescuento ?? 0) / 100M *  producto.Precio ;
        }
        else 
            ValorAPagar += producto.Precio;
    }
}
