using System.Text;

namespace Core;

public static class NumeroRomano
{

    private static Dictionary<int, char> _valores => new()
    {
        { 1000,'M'},
        { 100, 'C'},
        { 10, 'X'},
        { 5, 'V'},
        { 1, 'I'}
    };
    public static string Convertir(int numero)
    {
        return ProcesarNumeroRomano(numero);
    }

    private static string ProcesarNumeroRomano(int numero)
    {
        if (_valores.TryGetValue(numero, out char letra)) return letra.ToString();
        
        StringBuilder numeroRomano = new StringBuilder();
        
        int decenas = numero / 10;
        int unidades = numero % 10;
        
        for (int i = 0 ; i < decenas; i++)
        {
            numeroRomano.Append(_valores.GetValueOrDefault(10));
        }
        
        if(unidades > 0)
            numeroRomano.Append(new string(_valores.GetValueOrDefault(1), unidades));
        
        return numeroRomano.ToString();
    }
}