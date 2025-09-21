using System;

namespace Conditionals;

public class NumberValidations
{
    public static void EvenOrOdd()
    {
        //================================================================
        //Par o impar con condicional ternario
        Console.WriteLine("Ingrese un numero");
        int number = Convert.ToInt32(Console.ReadLine());

        string result = (number % 2 == 0) ? "Es par" : "Es inpar";
        Console.WriteLine(result);
        //================================================================
    }

    public static void QualificationValidator()
    {
        Console.WriteLine("Ingre la calificacion");

        int grade = Convert.ToInt32(Console.ReadLine());

        switch (grade)
        {
            case >= 90:
                Console.WriteLine("Exelente");
                break;
            case >= 70:
                Console.WriteLine("Bueno");
                break;
            case >= 60:
                Console.WriteLine("Debes Recuperar");
                break;
            case < 60:
                Console.WriteLine("Perdiste");
                break;
        }

    }

    public static void TernaryOperator()
    {
        Console.WriteLine("Ingrese la calificacion");

        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade < 0 || grade => 100 )
        {
            Console.WriteLine("Dato invalido");
        }else
        {
            //Operador ternario
            string result = grade >= 90 ? "Exelente" :
                grade >= 70 ? "Bueno" :
                grade >= 60 ? "Recuperar" :
                "reprobado";
            Console.WriteLine(result);
        }
}
        
}