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

    [Theory]
    [InlineData(4,"IV")]
    [InlineData(9,"IX")]
    [InlineData(40,"XL")]
    [InlineData(90,"XC")]
    [InlineData(400,"CD")]
    [InlineData(900,"CM")]
    public void Si_DigitoNumeroQueRequiereSustracion_DebeConvertirALaLetraCorrespondiente(short numero, string esperado)
    {
        string resultado = NumeroRomano.Convertir(numero);
        
        resultado.Should().Be(esperado);
    }


    [Fact]
    public void Si_Digito7ElSistema_DebeConvertirAVII()
    {
        string resultado = NumeroRomano.Convertir(7);
        
        resultado.Should().Be("VII");
    }

    [Fact]
    public void Si_Digito48ElSistema_DebeConvertirAXLVIII()
    {
        string resultado = NumeroRomano.Convertir(48);
        
        resultado.Should().Be("XLVIII");
    }

    [Fact]
    public void SiDigito63ElSistema_DebeConvertirALXIII()
    {
        string resultado = NumeroRomano.Convertir(63);
        
        resultado.Should().Be("LXIII");
    }

    [Fact]
    public void Si_Digito1000ElSistema_DebeLanzarExcepcion()
    {
        Action caller = () => NumeroRomano.Convertir(1000);

        caller.Should().ThrowExactly<ArgumentException>();
    }
}

