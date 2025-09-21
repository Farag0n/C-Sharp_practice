using System.Runtime.CompilerServices;

namespace ClassDinamic;

public class Funciones
{
    public static void ejemplos()
    {
        int suma = sumar(5, 6);
        int multi = multiplicar(6, 8);
        Console.WriteLine($"resultado {suma}");
        Console.WriteLine($"resultado 2 {multi}");
    }

    public static int sumar(int a, int b)
    {
        return a + b;
    }

    public static int multiplicar(int a, int b)
    {
        return a * b;
    }
}