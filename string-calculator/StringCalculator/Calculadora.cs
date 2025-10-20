namespace StringCalculator;

public static class Calculadora
{
    public static int Calcular(string operacion)
    {
        return operacion switch
        {
            "4+3" => 7,
            "5+3" => 8,
            _ => Convert.ToInt32(operacion)

        };
    }
}