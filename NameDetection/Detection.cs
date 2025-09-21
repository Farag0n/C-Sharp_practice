namespace NameDetection;

public class Detection
{
    static List<string> womenNames = new List<string> {};
    static List<string> menNames = new List<string> {};
    static string bannedMan = "roberto";
    static string bannedWoman = "emilcen";
    
    //Funcion para escanear los nombres masculinos
    public static void ScannerMenNames()
    {
        Console.WriteLine("Ingrese nombres masculinos");
        while (true)
        {
            string name = Console.ReadLine();
            menNames.Add(name);
            
        }
    }
}