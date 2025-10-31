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

    [Fact]
    public void Si_Retiro1ElCajeroAutomatico_DebeMostrarComoSalida1MonedaDeValor1()
    {
        CajeroAutomatico cajeroAutomatico = new();

        var salida = cajeroAutomatico.Retirar(1);

        salida.Should().Be("1 moneda de valor 1");
    }


    [Fact]
    public void Si_Retiro2ElCajeroAutomatico_DebeMostrarComoSalida1MonedaDeValor2()
    {
        CajeroAutomatico cajeroAutomatico = new();

        var salida = cajeroAutomatico.Retirar(2);

        salida.Should().Be("1 moneda de valor 2");
    }
}