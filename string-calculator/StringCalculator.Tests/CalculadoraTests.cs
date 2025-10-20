using AwesomeAssertions;

namespace StringCalculator.Tests;

public class CalculadoraTests
{
    [Fact]
    public void Si_LaEntradaEs1_DebeCalcular1()
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular("1");

        // Assert
        resultado.Should().Be(1);
    }

    [Fact]
    public void Si_LaEntradaEsmenos2_DebeCalcular2()
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular("-2");

        // Assert
        resultado.Should().Be(-2);
    }

    [Fact]
    public void Si_LaEntradaEs4Mas3_DebeCalcular7()
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular("4+3");

        // Assert
        resultado.Should().Be(7);
    }

    [Fact]
    public void Si_LaEntradaEs5Mas3_DebeCalcular8()
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular("5+3");

        // Assert
        resultado.Should().Be(8);
    }

    [Fact]
    public void Si_LaEntradaEsMenos2MasDiezMasDos_DebeCalcular10()
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular("-2+10+2");

        // Assert
        resultado.Should().Be(10);
    }

    [Fact]
    public void Si_LaEntradaEs5Menos2_DebeCalcular3()
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular("5-2");

        // Assert
        resultado.Should().Be(3);
    }

    [Fact]
    public void Si_LaEntradaEs6Menos4_DebeCalcular2()
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular("6-4");

        // Assert
        resultado.Should().Be(2);
    }

    [Fact]
    public void Si_laEntradaEsmenos5Menos2_DebeCalcularMenos7()
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular("-5-2");

        // Assert
        resultado.Should().Be(-7);
    }

    [Fact]
    public void Si_LaEntradaEs4Mas_DebeLanzarArgumentExcepcion()
    {
        // Arrange && Act
        Action funcionCalculo = () => { Calculadora.Calcular("4+"); };

        // Assert
        funcionCalculo.Should().Throw<ArgumentException>().WithMessage("operación no valida");
    }
}


