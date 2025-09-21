namespace ClassDinamic;

public class Ciclos
{
    public static void CiclosFor()
    {
        //recorrer notas (con un array)
        int[] notas = { 10, 20, 30, 40, 50 };
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"Las notatas son {notas[i]}");
        }

        //Esto se dibide en tres
        //Inicializacion (se crea variable)
        //Condicion (que la variable sea menor a diez)
        //Incremento/decremento (se suma o resta)
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

    }

    public static void ForSomeNumbers()
    {
        // for (int i = 2; i <= 20; i+=2)
        // {
        //     Console.WriteLine(i);
        // }

        // for (int i = 50; i >= 0; i -= 2)
        // {
        //     Console.WriteLine(i);
        // }

        for (int i = 0; i >= 0 && i <= 50; i += 3)
        {
            string resultado = (i % 2 == 0) ? "El numero es par" : "El numero es impar";
            Console.WriteLine($"Numero: {i} {resultado}");
        }
            
            
    }

    public static void Whiles()
    {
        int contador = 0;
        while (contador <= 5)
        {
            Console.WriteLine($"El contador es {contador}");
            contador++;
        }
    }
}