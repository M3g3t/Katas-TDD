namespace StringCalculator;

public static class Calculadora
{
    public static int Calcular(string operacion)
    {
        return operacion switch
        {
            string ope when ope.Contains("+") => ResolverSumatoria(ope),
            string ope when ope.Contains("-") && !ope.StartsWith("-")  => ResolverResta(ope),
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

    private static int ResolverResta(string operacion)
    {
        return Convert.ToInt32(operacion.Split("-")[0]) - Convert.ToInt32(operacion.Split("-")[1]);
    }
}