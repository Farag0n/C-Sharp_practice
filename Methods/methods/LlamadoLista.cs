namespace methods;

public class LlamadoLista
{
    public static void iniciarregistro()
    {
        string[] estudiantes = { "ana", "jorge", "andres", "deivis" };
        bool[] presente = new bool[estudiantes.Length];
        
        registrarAsistencia(estudiantes, presente);
        mostrarAsistencia(estudiantes, presente);
    }

    //Esto es un metodo para delegar trabajos
    public static void registrarAsistencia(string[] estudiantes, bool[] presente)
    {
        for (int i = 0; i < estudiantes.Length; i++)
        {
            Console.WriteLine($"{estudiantes[i]} esta persona asistio? s/n");
            string respuesta = Console.ReadLine();
            presente[i] = respuesta == "$";
        }
        
    }

    public static void mostrarAsistencia(string[] estudiantes, bool[] presente)
    {
        int contador = 0;
        for (int i = 0; i < estudiantes.Length; i++)
        {
            string estado = presente[i]? "presente" : "ausente";
            Console.WriteLine($"{estudiantes[i]} status: {estado}");
            if (presente[i]) contador++;
        }
        double porcentaje = (double)contador * 100 / estudiantes.Length;
        Console.WriteLine($"Porsentaje de asistencia es: {porcentaje:F2}%");
    }
}