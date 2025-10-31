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

    [Fact]
    public void Si_Retiro5ElCajeroAutomatico_DebeMostrarComoSalida1BilleteDeValor5()
    {
        CajeroAutomatico cajeroAutomatico = new();

        var salida = cajeroAutomatico.Retirar(5);

        salida.Should().Be("1 billete de valor 5");
    }

    [Fact]
    public void Si_Retiro10ElCajeroAutomatico_DebeMostrarComoSalida1BilleteDeValor10()
    {
        CajeroAutomatico cajeroAutomatico = new();

        var salida = cajeroAutomatico.Retirar(10);

        salida.Should().Be("1 billete de valor 10");
    }

    [Fact]
    public void Si_Retiro20ElCajeroAutomatico_DebeMostrarComoSalida1BilleteDeValor20()
    {
        
        CajeroAutomatico cajeroAutomatico = new();

        var salida = cajeroAutomatico.Retirar(20);

        salida.Should().Be("1 billete de valor 20");
    }
}