namespace StringCalculator;

public static class Calculadora
{
    public static int Calcular(string operacion)
    {
        return operacion switch
        {
            string ope when ope.Contains("+") => ResolverSumatoria(ope),
            string ope when (ope.Count(c => c == '-') == 1 && ope.StartsWith("-")) || !ope.Contains("-") => Convert.ToInt32(operacion),
            _ => ResolverResta(operacion),
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
        int? resultado = null;
        string operadorAdicional = "";
        foreach (string digito in operacion.Split("-"))
        {
            if(string.IsNullOrEmpty(digito))
                operadorAdicional = "-";
            else {
                if(resultado is null)
                    resultado = Convert.ToInt32(operadorAdicional + digito);
                else
                    resultado -=  Convert.ToInt32(operadorAdicional + digito);
                operadorAdicional = "";
            }
        }
        
        return resultado ?? 0;
    }
}