using System.Text;

namespace Core;

public static class NumeroRomano
{
    private static StringBuilder? _numeroRomanoSb;

    private static int _numeroAConvertir;

    private static int _unidades =>  _numeroAConvertir % 10;
    private static Dictionary<short, string> _valores => new()
    {
        { 1000,"M"},
        { 900,"CM"},
        { 500, "D"},
        { 400, "CD"},
        { 100, "C"},
        { 90, "XC"},
        { 50, "L"},
        { 40, "XL"},
        { 10, "X"},
        { 9, "IX"},
        { 5, "V"},
        { 4, "IV"},
        { 1, "I"}
    };
    public static string Convertir(short numero)
    {
        _numeroRomanoSb = new();
        _numeroAConvertir = numero;
        
        if (ProcesarNumeroDirecto(numero) is string letra)
            return letra;
        
        
        ProcesarDecenas(numero);
        ProcesarUnidades();
        
        return _numeroRomanoSb.ToString();
    }

    private static string? ProcesarNumeroDirecto(short numero)
    {
        _valores.TryGetValue(numero, out string? letra);
        return letra;
    }
    
    private static void ProcesarDecenas(int numero)
    {
        int decenas = numero / 10;
        
        for (int i = 0 ; i < decenas; i++)
        {
            _numeroRomanoSb!.Append(char.Parse(_valores[10]));
        }
    }

    private static void ProcesarUnidades()
    {
        if (_unidades == 7)
        {
            _numeroRomanoSb!.Append(_valores[5]);
            _numeroRomanoSb!.Append(_valores[1]);
            _numeroRomanoSb!.Append(_valores[1]);
            return;
        }

        if(_unidades > 0)
            _numeroRomanoSb!.Append(new string(char.Parse(_valores[1]), _unidades));
    }
}