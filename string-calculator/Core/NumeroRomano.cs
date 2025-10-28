using System.Text;

namespace Core;

public static class NumeroRomano
{
    private static StringBuilder? _numeroRomanoSb;
    
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
        
        if (ProcesarNumeroDirecto(numero) is string letra)
            return letra;

        IterarNumero(numero);
        
        return _numeroRomanoSb.ToString();
    }

    private static string? ProcesarNumeroDirecto(short numero)
    {
        var valor = _valores.FirstOrDefault(v => v.numero == numero);
        return valor.letra;
    }

    private static void IterarNumero(short numero)
    {
        short numeroProcesado = numero;
        while (numeroProcesado is not 0)
        {
            foreach (var val in _valores)
            {
                if (val.numero <= numeroProcesado)
                {
                    _numeroRomanoSb!.Append(val.letra);
                    numeroProcesado -= val.numero;
                    break;
                }
            }
        }
    }
}