namespace Core;

public static class NumeroRomano
{
    public static string Convertir(int numero)
    {
        string r = "";

        for (int i = 1; i <= numero; i++)
        {
            r += "I";
        }
        return r;
    }
}