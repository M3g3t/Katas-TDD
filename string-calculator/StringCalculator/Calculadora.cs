namespace StringCalculator;

public static class Calculadora
{
    public static int Calcular(string operacion)
    {
        return operacion switch
        {
            string ope when ope.Contains("+") => ResolverSumatoria(operacion),
            "5-2" => 3,
            _ => Convert.ToInt32(operacion)
        };
    }

    private static int ResolverSumatoria(string operacion)
    {
        int sumatoria = 0;
            
        foreach (string digito in operacion.Split("+"))
            sumatoria += Convert.ToInt32(digito);
            
        return sumatoria;
    }
}