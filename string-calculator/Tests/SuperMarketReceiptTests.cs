using AwesomeAssertions;
using Core.SuperMarket;

namespace Core.Tests;

public class SuperMarketReceiptTests
{
    [Fact]
    public void Si_InicializoCajaRegistradoraElValorAPagar_Debe_Ser0()
    {
        var cajaRegistradora = new CajaRegistradora();

        cajaRegistradora.ValorAPagar.Should().Be(0);
    }

    [Fact]
    public void Si_RegistroProductoConPrecio10ElValorAPagar_Debe_Ser10()
    {
        var cajaRegistradora = new CajaRegistradora();

        cajaRegistradora.RegistrarProducto(new Producto("productop", 10));

        cajaRegistradora.ValorAPagar.Should().Be(10);
    }

    [Fact]
    public void Si_RegistroDosProductosUnoConPrecio5yOtroConPrecio10ElValorAPagar_Debe_Ser15()
    {
        var cajaRegistradora = new CajaRegistradora();

        cajaRegistradora.RegistrarProducto(new Producto("productop", 5));
        cajaRegistradora.RegistrarProducto(new Producto("productop", 10));

        cajaRegistradora.ValorAPagar.Should().Be(15);
    }

    [Fact]
    public void Si_RegistroUnCepilloDentalConPrecio5ElValorAPagar_Debe_Ser5()
    {
        var cajaRegistradora = new CajaRegistradora();

        cajaRegistradora.RegistrarProducto(new Producto("Cepillo Dental", 5));

        cajaRegistradora.ValorAPagar.Should().Be(5);
    }

    [Fact]
    public void Si_RegistroUnaCremaDentalConPrecio6QueTieneDescuentoDe50PorCientoElValorAPagar_Debe_Ser3()
    {
        var cajaRegistradora = new CajaRegistradora();
        var productoConDescuento = new Producto("Crema Dental", 6);
        
        cajaRegistradora.RegistrarProducto(productoConDescuento);
        
        cajaRegistradora.ValorAPagar.Should().Be(3);
    }
    

}