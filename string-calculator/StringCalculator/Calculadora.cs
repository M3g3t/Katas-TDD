namespace StringCalculator;

public static class Calculadora
{
    public static int Calcular(string operacion)
    {
        return operacion switch
        {
            string ope when ope.Contains("+") => ResolverSumatoria(operacion),
            string ope when ope.Contains("-") && !ope.StartsWith("-")  => Convert.ToInt32(ope.Split("-")[0]) - Convert.ToInt32(ope.Split("-")[1]),
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