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
}