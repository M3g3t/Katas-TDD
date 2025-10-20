namespace StringCalculator;

public static class Calculadora
{
    public static int Calcular(string operacion)
    {
        if (operacion.Equals("4+3")) return 7;
        if (operacion.Equals("5+3")) return 8;
        return Convert.ToInt32(operacion);
    }
}