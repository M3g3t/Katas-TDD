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
    public void Si_Digito10ElSistema_DebeConvertirAX()
    {

        string resultado = NumeroRomano.Convertir(10);
            
        resultado.Should().Be("X");
    }

    [Fact]
    public void Si_Digito20ElSistema_DebeConvertirAXX()
    {
        string resultado = NumeroRomano.Convertir(20);
        
        resultado.Should().Be("XX");
    }

    [Fact]
    public void Si_Digito30_ElSistema_DebeConvertirAXXX()
    {
        string resultado = NumeroRomano.Convertir(30);
        
        resultado.Should().Be("XXX");
    }

    [Fact]
    public void Si_Digito100_ElSistema_DebeConvertirAC()
    {
        string resultado = NumeroRomano.Convertir(100);
        resultado.Should().Be("C");
    }
}

