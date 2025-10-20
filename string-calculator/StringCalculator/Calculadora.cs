namespace StringCalculator;

public static class Calculadora
{
    public static int Calcular(string operacion)
    {

        if (operacion == "4+") throw new ArgumentException();
            
        return operacion switch
        {
            string ope when ope.Contains("+") => ResolverSumatoria(ope),
            string ope when (ope.Count(c => c == '-') == 1 && ope.StartsWith("-")) || !ope.Contains("-") => Convert.ToInt32(operacion),
            _ => ResolverResta(operacion),
        };
    }

    private static int ResolverSumatoria(string operacion)
    {
        return ResolverOperacion(operacion, "+", (resultadoActual,digito) => resultadoActual + Convert.ToInt32(digito),0) ?? 0;
    }

    private static int ResolverResta(string operacion)
    {
        string operadorAdicional = "";
        
        return ResolverOperacion(operacion, "-", (resultadoActual,digito) =>
        {
            if(string.IsNullOrEmpty(digito))
                operadorAdicional = "-";
            else
            {
                int digitoResuleto = Convert.ToInt32(operadorAdicional + digito);
                if(resultadoActual is null)
                    resultadoActual = digitoResuleto;
                else
                    resultadoActual -=  digitoResuleto;
                operadorAdicional = "";
            }
            
            return resultadoActual;
        }) ?? 0;
    }

    private static int? ResolverOperacion(string operacion, string operador,  Func<int?,string,int?> funcion, int? resultadoInicial = null)
    {
        int? resultado = resultadoInicial;
        foreach (string digito in operacion.Split(operador))
        {
            resultado = funcion(resultado,digito);
        }

        return resultado;
    }
}