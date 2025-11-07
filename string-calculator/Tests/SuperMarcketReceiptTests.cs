using AwesomeAssertions;

namespace Core.Tests;

public class SuperMarcketReceiptTests
{
    [Fact]
    public void Si_InicializoCajaRegistradoraElValorRegistradoInicial_Debe_Ser0()
    {
        var cajaRegistradora = new CajaRegistradora();
        
        cajaRegistradora.ValorRegistrado.Should().Be(0);
    }

    [Fact]
    public void Si_RegistroProductoConPrecio10_ElValorAPagar_Debe_Ser10()
    {
        var cajaRegistradora = new CajaRegistradora();

        cajaRegistradora.RegistrarProducto(10);
        
        cajaRegistradora.ValorRegistrado.Should().Be(10);
    }
}