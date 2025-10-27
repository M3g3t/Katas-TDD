namespace Core;

public static class NumeroRomano
{
    public static string Convertir(int numero)
    {
        return ProcesarNumeroRomano(numero);
    }

    private static string ProcesarNumeroRomano(int numero)
    {
        string numeroRomano = string.Empty;

        numeroRomano = ProcesarDecena(numero);

        if (!string.IsNullOrEmpty(numeroRomano)) return numeroRomano;

        return ProcesarUnidades(numero);
    }


    private static string ProcesarDecena(int numero)
    {
        string numeroRomano = string.Empty;

        for (int i = 1; i <= numero; i++)
        {
            if (i % 10 == 0)
            {
                numeroRomano += "X"; 
            }
        }
        
        return numeroRomano;
    }

    private static string ProcesarUnidades(int numero)
    {
        string numeroRomano = string.Empty;
        
        for (int i = 1; i <= numero; i++)
            numeroRomano += "I";

        return numeroRomano;
    }
}