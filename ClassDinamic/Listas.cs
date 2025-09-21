using System.Transactions;

using System.Collections;
namespace ClassDinamic;

public class Listas
{
    public static void ejemplosListas()
    {
        List<string> frutas = new List<string> { "banano", "peras", "uvas" };
        frutas.Add("manzana");
        Console.WriteLine(frutas);

        List<int> edades = new List<int> { 10, 20, 30, 40, 50 };



        //Ciclo for
        foreach (var fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        foreach (var edad in edades)
        {
            Console.WriteLine(edad);
        }
    }

    public static void ejemplosArrayList()
    {
        ArrayList name = new ArrayList();
        name.Add(1000);
        name.Add(true);
        name.Add(4.3);

        foreach (var i in name)
        {
            Console.WriteLine($"Datos en el ArrayList {i}");
        }
    }
}