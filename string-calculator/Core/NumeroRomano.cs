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

        if (numero == 10) return "X";
        
        for (int i = 1; i <= numero; i++)
            numeroRomano += "I";

        return numeroRomano;
    }


}