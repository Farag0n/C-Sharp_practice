namespace Apples_System;

public class ShopApples
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del cliente");
        String name = Console.ReadLine();
        
        Console.WriteLine("Cuantas manzanas desea llevar");

        int quantityApples = int.Parse(Console.ReadLine());
        
        Console.WriteLine("cual es el precio de las manzanas");
        double priceApples = double.Parse(Console.ReadLine());

        double totalApples = quantityApples * priceApples;
        
        Console.WriteLine("Desea incluir bolsa");
        bool statusBag = bool.Parse(Console.ReadLine());

        double priceBag = 200;

        double total = totalApples;

        if (statusBag)
        {
            total += priceBag;
        }
        
        Console.WriteLine($"El total de la compra fue {total} y el nombre del cliente {name}");
    }
}