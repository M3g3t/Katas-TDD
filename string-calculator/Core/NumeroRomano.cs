using System.Text;

namespace Core;

public static class NumeroRomano
{
    private static StringBuilder? _numeroRomanoSb;

    private static int _numeroAConvertir;

    private static int _unidades =>  _numeroAConvertir % 10;
    private static (short numero, string letra)[] _valores =>
    [
        ( 1000,"M"),
        ( 900,"CM"),
        ( 500, "D"),
        ( 400, "CD"),
        ( 100, "C"),
        ( 90, "XC"),
        ( 50, "L"),
        ( 40, "XL"),
        ( 10, "X"),
        ( 9, "IX"),
        ( 5, "V"),
        ( 4, "IV"),
        ( 1, "I")
    ];
    public static string Convertir(short numero)
    {
        _numeroRomanoSb = new();
        _numeroAConvertir = numero;
        
        if (ProcesarNumeroDirecto(numero) is string letra)
            return letra;
        
            while (numero is not 0)
            {
                foreach (var val in _valores)
                {
                    if (val.numero <= numero)
                    {
                        _numeroRomanoSb.Append(val.letra);
                        numero -= val.numero;
                        break;
                    }
                }
            }
        
        return _numeroRomanoSb.ToString();
    }

    private static string? ProcesarNumeroDirecto(short numero)
    {

        var valor = _valores.FirstOrDefault(v => v.numero == numero);
        return valor.letra;
    }
    
    private static void ProcesarDecenas(int numero)
    {
        int decenas = numero / 10;
        
        for (int i = 0 ; i < decenas; i++)
        {
            _numeroRomanoSb!.Append(_valores.First(v => v.numero == 10));
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
            _numeroRomanoSb!.Append(new string(char.Parse(_valores.First(v => v.numero == 1).letra), _unidades));
    }
}