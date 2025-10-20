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
