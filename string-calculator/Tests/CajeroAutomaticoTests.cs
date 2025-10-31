using AwesomeAssertions;

namespace Core.Tests;

public class CajeroAutomaticoTests
{
    [Fact]
    public void Si_ElCajeroAutomaticoNoEsUsado_Debe_Tener5100ComoValorDisponible()
    {
        CajeroAutomatico cajeroAutomatico = new();

        int dineroDisponible = cajeroAutomatico.ConsultarDineroDisponible();

        dineroDisponible.Should().Be(5100);
    }
    
    [Theory]
    [InlineData(1,"1 moneda de valor 1")]
    [InlineData(2,"1 moneda de valor 2")]
    [InlineData(5,"1 billete de valor 5")]
    [InlineData(10,"1 billete de valor 10")]
    [InlineData(20,"1 billete de valor 20")]
    [InlineData(50,"1 billete de valor 50")]
    [InlineData(100,"1 billete de valor 100")]
    [InlineData(200,"1 billete de valor 200")]
    [InlineData(500,"1 billete de valor 500")]
    public void Si_RetiroValorDelCajeroAutomaticoQueCorrepondaAUnaSolaUnidad_DebeMostrarComoSalidaUnaUnidadConSuValorCorrespondiente(int valorARetirar, string valorEsperado)
    {
        CajeroAutomatico cajeroAutomatico = new();

        var salida = cajeroAutomatico.Retirar(valorARetirar);
   
        salida.Should().Be(valorEsperado);
    }
}