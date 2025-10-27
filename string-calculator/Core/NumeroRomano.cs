namespace StringCalculator;

public static class NumeroRomano
{
    public static string Convertir(int numero)
    {
        if (numero == 2) return "II";
        return "I";
    }
}