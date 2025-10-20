using AwesomeAssertions;

namespace StringCalculator.Tests;

public class CalculadoraTests
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


