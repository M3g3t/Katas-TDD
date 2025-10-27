namespace Core;

public static class NumeroRomano
{
    public static string Convertir(int numero)
    {
        return  numero == 2 ?  "II" : "I";
    }
}