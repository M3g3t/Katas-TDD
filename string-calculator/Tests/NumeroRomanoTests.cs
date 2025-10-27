using AwesomeAssertions;

namespace StringCalculator.Tests;

public class NumeroRomanoTests
{
    [Fact]
    public void Si_Digito1ElSistema_DebeConvertirAI()
    {
        var numeroRomano = new NumeroRomano();

        var resultado = numeroRomano.Convertir(1);
        
        resultado.Should().Be("I");
    }
}

public class NumeroRomano
{
    public object Convertir(int i)
    {
        return "I";
    }
}