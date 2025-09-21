namespace Cine;

public class TicketCinema
{
    static void Main(string[] args)
    {
        //Valor de la entrada
        double ticket = 24.600;
        double totalTicket = 0.0;
        
        
        //Datos ingresados
        Console.WriteLine("Bienvenido al Cine");
        
        Console.WriteLine("Ingrese su nombre");
        string name = Console.ReadLine();
        
        Console.WriteLine("Ingrese su edad");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ingrese el dia de su funcion");
        Console.WriteLine("lun-mar-mier-jue-vier-sab-do");
        string day = Console.ReadLine();
        double dayDiscunt = 25.0;
        
        
        Console.WriteLine("Tiene tarjeta de descuento");
        bool cardStatus = Convert.ToBoolean(Console.ReadLine());
        double discuntCard = 25.0;

        double discuntAge = age <= 5 ?  totalTicket = ticket * (1 - (25.0 / 100.0)) :
            age <= 12 totalTicket = ticket * (1 - (25.0 / 100.0));


    }
}