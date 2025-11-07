using AwesomeAssertions;

namespace Core.Tests;

public class SuperMarcketReceiptTests
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

        cajaRegistradora.RegistrarProducto(10);
        
        cajaRegistradora.ValorAPagar.Should().Be(10);
    }

    [Fact]
    public void Si_RegistroDosProductosUnoConPrecio5yOtroConPrecio10ElValorAPagar_Debe_Ser15()
    {
        var cajaRegistradora = new CajaRegistradora();
        
        cajaRegistradora.RegistrarProducto(5);
        cajaRegistradora.RegistrarProducto(10);

        cajaRegistradora.ValorAPagar.Should().Be(15);


    }

    [Fact]
    public void Si_RegistroUnCepilloDentalConPrecio5ElValorAPagar_Debe_Ser5()
    {
        var cajaRegistradorra = new CajaRegistradora();
        
        cajaRegistradorra.RegistrarProducto(new Producto("Cepillo Dental",5));

        cajaRegistradorra.ValorAPagar.Should().Be(5);
        


    }
}