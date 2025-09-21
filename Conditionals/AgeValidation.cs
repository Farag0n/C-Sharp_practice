using System;

namespace Conditionals;

public class AgeValidation
{
    //Esto hace un metodo
    //El public significa que es un metodo publico que se puede usar sin necesidad de la clase
    //El static dice que el metodo es independiente a un objeto
    //El void significa que no retorna nigun dato
    public static void AgeValidator()
    {
        Console.WriteLine("Ingrese su edad");

        int age = Convert.ToInt32(Console.ReadLine());

        string validationAge = (age >= 18) ? "Eres mayor de edad" : "Eres menor de edad";
    }
    
}