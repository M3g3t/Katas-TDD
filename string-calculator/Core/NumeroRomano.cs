using System.Text;

namespace Core;

public static class NumeroRomano
{

    private static Dictionary<short, char> _valores => new()
    {
        { 1000,'M'},
        { 500, 'D'},
        { 100, 'C'},
        { 50, 'L'},
        { 10, 'X'},
        { 5, 'V'},
        { 1, 'I'}
    };
    public static string Convertir(short numero)
    {
        return ProcesarNumeroRomano(numero);
    }

    private static string ProcesarNumeroRomano(short numero)
    {
        if (ProcesarNumeroDirecto(numero) is char letra)
            return letra.ToString();
        
        StringBuilder numeroRomano = new StringBuilder();
        
        int decenas = numero / 10;
        int unidades = numero % 10;
        
        for (int i = 0 ; i < decenas; i++)
        {
            numeroRomano.Append(_valores[10]);
        }
        
        if(unidades > 0)
            numeroRomano.Append(new string(_valores[1], unidades));
        
        return numeroRomano.ToString();
    }

    private static char? ProcesarNumeroDirecto(short numero)
    {
        if (_valores.TryGetValue(numero, out char letra)) return letra;

        return null;
    }
}