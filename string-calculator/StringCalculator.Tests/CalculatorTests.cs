using AwesomeAssertions;

namespace StringCalculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void Si_LaEntradaEs1_DebeCalcularUno()
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular("1");

        // Assert
        resultado.Should().Be(1);
    }
}

public class Calculadora
{
    public static int Calcular(string s)
    {
        return 1;
    }
}
