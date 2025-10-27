using System.Text;

namespace Core;

public static class NumeroRomano
{
    public static string Convertir(int numero)
    {
        return ProcesarNumeroRomano(numero);
    }

    private static string ProcesarNumeroRomano(int numero)
    {
        if (numero == 100) return "C";
        if (numero == 1000) return "M";
        
        StringBuilder numeroRomano = new StringBuilder();
        
        int decenas = numero / 10;
        int unidades = numero % 10;
        
        for (int i = 0 ; i < decenas; i++)
        {
            numeroRomano.Append("X");
        }
        
        if(unidades > 0)
            numeroRomano.Append(new string('I', unidades));
        
        return numeroRomano.ToString();
    }
}