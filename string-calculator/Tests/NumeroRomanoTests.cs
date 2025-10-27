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
    public void Si_Digito30ElSistema_DebeConvertirAXXX()
    {
        string resultado = NumeroRomano.Convertir(30);
        
        resultado.Should().Be("XXX");
    }

    [Fact]
    public void Si_Digito100ElSistema_DebeConvertirAC()
    {
        string resultado = NumeroRomano.Convertir(100);
        
        resultado.Should().Be("C");
    }

    [Fact]
    public void Si_Digito1000ElSistema_DebeConvertirAM()
    {
        string resultado = NumeroRomano.Convertir(1000);
        
        resultado.Should().Be("M");
    }

    [Fact]
    public void Si_Digito5ElSistema_Debe_ConvertirAV()
    {
        string resultado = NumeroRomano.Convertir(5);
        
        resultado.Should().Be("V");
    }
}

