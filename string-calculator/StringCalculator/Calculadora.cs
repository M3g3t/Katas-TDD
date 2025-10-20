namespace StringCalculator;

public static class Calculadora
{
    public static int Calcular(string operacion)
    {
        if (operacion.Contains("+"))
            return ResolverSumatoria(operacion);

        return Convert.ToInt32(operacion);
    }

    private static int ResolverSumatoria(string operacion)
    {
        int sumatoria = 0;
            
        foreach (string digito in operacion.Split("+"))
            sumatoria += Convert.ToInt32(digito);
            
        return sumatoria;
    }
}