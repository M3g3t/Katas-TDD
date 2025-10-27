using AwesomeAssertions;

namespace Core.Tests;

public class NumeroRomanoTests
{
    [Theory]
    [InlineData(1,"I")]
    [InlineData(10,"X")]
    [InlineData(100,"C")]
    [InlineData(1000,"M")]
    public void Si_DigitoNumeroBase1ElSistema_DebeConvertirALaLetraCorrespondiente(short numero, string esperado)
    {
        string resultado = NumeroRomano.Convertir(numero);
        
        resultado.Should().Be(esperado);
    }
    

    [Fact]
    public void Si_Digito2ElSistema_DebeConvertirAII()
    {
        string resultado = NumeroRomano.Convertir(2);

        resultado.Should().Be("II");
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
    

    [Theory]
    [InlineData(5,"V")]
    [InlineData(50,"L")]
    [InlineData(500,"D")]
    public void Si_DigitoNumeroBase5ElSistema_DebeConvertirALaLetraCorrespondiente(short numero, string esperado)
    {
        string resultado = NumeroRomano.Convertir(numero);
        
        resultado.Should().Be(esperado);
    }

    [Fact]
    public void Si_Digito4ElSistema_DebeConvertirAIV()
    {
        string resultado = NumeroRomano.Convertir(4);
        
        resultado.Should().Be("IV");
    }

    [Fact]
    public void Si_Digito9ElSistema_DebeConvertirAIX()
    {
        string resultado = NumeroRomano.Convertir(9);
        
        resultado.Should().Be("IX");
    }
}

