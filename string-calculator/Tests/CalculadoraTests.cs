using AwesomeAssertions;

namespace StringCalculator.Tests;

public class CalculadoraTests
{
    [Theory]
    [InlineData("1",1)]
    [InlineData("-2",-2)]
    public void Si_LaEntradaEsUnNumero_DebeRetornarlo(string operacion, int resultadoEsperado)
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular(operacion);

        // Assert
        resultado.Should().Be(resultadoEsperado);
    }
    
    [Theory]
    [InlineData("4+3",7)]
    [InlineData("5+3",8)]
    [InlineData("-2+10+2",10)]
    public void Si_LaEntradaEsUnaSuma_DebeRetonarElResultado(string operacion, int resultadoEsperado)
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular(operacion);

        // Assert
        resultado.Should().Be(resultadoEsperado);
    }
    
    [Theory]
    [InlineData("5-2",3)]
    [InlineData("6-4",2)]
    [InlineData("-5-2",-7)]
    public void Si_LaEntradaEsUnaResta_DebeRetonarElResultado(string operacion, int resultadoEsperado)
    {
        // Arrange && Act
        int resultado = Calculadora.Calcular(operacion);

        // Assert
        resultado.Should().Be(resultadoEsperado);
    }
    
    [Theory]
    [InlineData("4+")]
    [InlineData("1+5-2+2")]
    public void Si_LaEntradaNoEsUnaOperacionValidaONumero_DebeLanzarArgumentExcepcion(string operacion)
    {
        // Arrange && Act
        Action funcionCalculo = () => { Calculadora.Calcular(operacion); };

        // Assert
        funcionCalculo.Should().Throw<ArgumentException>().WithMessage("operación no valida");
    }
    
}


