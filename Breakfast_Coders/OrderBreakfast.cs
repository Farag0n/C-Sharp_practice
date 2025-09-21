
public class OrderBreakfast
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Que desea pedir el dia de hoy");
        }
    }
    
    public const double priceCoffee = 1.900;
    public const double priceEgg = 4.700;
    
    //Funcion para elegir el desayuno
    public void BreakfastCoffee()
    {
        int quantityEggs = 0;
        
        Console.WriteLine("Digite la cantidad de huevos que desea");
        quantityEggs = Console.ReadLine();
        
        double total = quantityEggs + priceCoffee;
        
        Console.WriteLine($"El total de su orden es de {total}");
    }

    public void CompletBreakfast()
    {
        
    }

}