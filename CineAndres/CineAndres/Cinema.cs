namespace CineAndres;

public class Cinema
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre");
        string nombre = Console.ReadLine();
        
        Console.WriteLine("Ingrese su edad");
        int edad = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el dia de la semana");
        string dia = Console.ReadLine().ToLower();
        
        Console.WriteLine("Tiene una tarjeta de descuento si/no");
        bool tieneTarjeta = Convert.ToBoolean(Console.ReadLine());

        double precioCine = 20000;
        double porsentaje = 0;
        
        //Se hace el descuento si es miercoles
        porsentaje += (dia == "miercoles") ? 0.25 : 0.0;
        
        //Validacion de la tarjeta
        porsentaje += (tieneTarjeta) ? 0.25 : 0.0;
        
        //Validacion de edad
        porsentaje += (edad <= 5) ? 0.25 :
            (edad >= 6 && edad <= 12) ? 0.15 : 0.0;

        double total = precioCine * (1 - (porsentaje / precioCine));
        
        Console.WriteLine($"El cliente es {nombre}");
        Console.WriteLine($"La edad del cliente es {edad}");
        Console.WriteLine($"Su funcion es el dia {dia}");
        Console.WriteLine($"Esta usanto tarjeta {tieneTarjeta}");
        Console.WriteLine($"Porsentaje de descuento {porsentaje}");
        Console.WriteLine($"El total de la boleta es {total}");


    }
}