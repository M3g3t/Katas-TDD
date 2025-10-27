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
        
        for (int i = 1; i <= numero; i++)
            numeroRomano += "I";

        return numeroRomano;
    }


    private static string ProcesarDecena(int numero)
    {
        if (numero is 10) return "X";
        if (numero is 20) return "XX";

        return string.Empty;
    }
}