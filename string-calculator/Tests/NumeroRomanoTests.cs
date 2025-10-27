using AwesomeAssertions;

namespace Core.Tests;

public class NumeroRomanoTests
{
    [Fact]
    public void Si_Digito1ElSistema_DebeConvertirAI()
    {
        string resultado = NumeroRomano.Convertir(1);
        
        resultado.Should().Be("I");
    }

    [Fact]
    public void Si_Digito2ElSistema_DebeConvertirAII()
    {
        string resultado = NumeroRomano.Convertir(2);

        resultado.Should().Be("II");
    }

    [Fact]
    public void Si_Digito3ElSistema_DebeConvertirAIII()
    {

        string resultado = NumeroRomano.Convertir(3);
            
        resultado.Should().Be("III");
    }
}

