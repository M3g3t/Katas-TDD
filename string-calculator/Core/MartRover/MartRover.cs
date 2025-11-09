namespace StringCalculator.MartRover;

public class MartRover(Ubicacion ubicacionInicial)
{
    private Ubicacion _ubicacionInicial = ubicacionInicial;

    public Ubicacion ObtenerUbicacion()
    {
        return _ubicacionInicial;
    }

    public void CambiarOrientacion(char tipoGiro)
    {
        _ubicacionInicial = _ubicacionInicial with { Orientacion = CalcularOrientacion(tipoGiro) };
    }

    private char CalcularOrientacion(char tipoGiro)
    {
        if (FueGiradoALaDerechaYTieneOrientacion(tipoGiro, 'S'))
            return 'W';

        if (_ubicacionInicial.Orientacion == 'S' && tipoGiro == 'L')
            return 'E';
        if (tipoGiro == 'R')
            return 'E';

        return 'W';
    }

    private bool FueGiradoALaDerechaYTieneOrientacion(char tipoGiro, char orientacion) =>
        _ubicacionInicial.Orientacion == orientacion && tipoGiro == 'R';
}