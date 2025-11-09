using AwesomeAssertions;
using StringCalculator.MartRover;

namespace Core.Tests;

public class MartRoversTests
{
    [Fact]
    public void Si_InicializoUnMartRover_Debe_NoSerNulo()
    {
        var martRover = new MartRover(new Ubicacion(0, 0, 'N'));

        martRover.Should().NotBeNull();
    }

    [Fact]
    public void Si_InicializoUnMartRoverConLaUbicacion0Coma0_DebeEstarUbicadoEnEsaCordenada()
    {
        var ubicacionInicial = new Ubicacion(0, 0, 'N');
        var martRover = new MartRover(ubicacionInicial);

        martRover.ObtenerUbicacion().Should().BeEquivalentTo(ubicacionInicial);
    }

    [Fact]
    public void Si_InicializoUnMartRoverConLaOrientacionN_DebeEstarUbicadoEnLaOrientacionN()
    {
        var ubicacionInicial = new Ubicacion(0, 0, 'N');
        var martRover = new MartRover(ubicacionInicial);

        martRover.ObtenerUbicacion().Should().BeEquivalentTo(ubicacionInicial);
    }

    [Fact]
    public void Si_InicializoUnMartRoverConLaUbicacion1Coma1YOrientacionN_DebeEstarUbicadoEnEsaCordenadaYOrientacion()
    {
        var ubicacionInicial = new Ubicacion(1, 1, 'N');
        var martRover = new MartRover(ubicacionInicial);

        martRover.ObtenerUbicacion().Should().BeEquivalentTo(ubicacionInicial);
    }

    [Fact]
    public void Si_CambioOrientacionDeRoverALaIzquierdaYLaOrientacionInicialEsN_Debe_EstarOrientadoAW()
    {
        var martRover = new MartRover(new Ubicacion(0, 0, 'N'));

        martRover.CambiarOrientacion('L');

        var orientacion = martRover.ObtenerUbicacion().Orientacion;
        orientacion.Should().Be('W');
    }
    
    [Fact]
    public void Si_CambioOrientacionDeRoverALaDerechaYLaOrientacionInicialEsN_Debe_EstarOrientadoAE()
    {
        var martRover = new MartRover(new Ubicacion(0, 0, 'N'));

        martRover.CambiarOrientacion('R');

        var orientacion = martRover.ObtenerUbicacion().Orientacion;
        orientacion.Should().Be('E');
    }

    [Fact]
    public void Si_CambioOrientacionDeRoverALaDerechaYLaOrientacionInicialEsS_Debe_EstarOrientadoAW()
    {
        var martRover = new MartRover(new Ubicacion(0, 0, 'S'));

        martRover.CambiarOrientacion('R');

        var orientacion = martRover.ObtenerUbicacion().Orientacion;
        orientacion.Should().Be('W');
    }

    [Fact]
    public void Si_CambioOrientacionDeRoverALaIzquierdaYLaOrientacionInicialEsS_Debe_EstarOrientadoAE()
    {
        var martRover = new MartRover(new Ubicacion(0, 0, 'S'));

        martRover.CambiarOrientacion('L');

        var orientacion = martRover.ObtenerUbicacion().Orientacion;
        orientacion.Should().Be('E');
    }
    //
    // [Fact]
    // public void Si_CambioOrientacionDeRoverALaIzquierdaYLaOrientacionInicialEsN_Debe_EstarOrientadoAW()
    // {
    //     var martRover = new MartRover(new Ubicacion(0, 0, 'N'));
    //
    //     martRover.CambiarOrientacion('L');
    //
    //     var orientacion = martRover.ObtenerUbicacion().Orientacion;
    //     orientacion.Should().Be('W');
    // }
    
}