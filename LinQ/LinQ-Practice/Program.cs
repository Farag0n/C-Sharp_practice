using System;                      // Espacio de nombres básico: Console, tipos primarios, etc.
using System.Collections.Generic;  // Contiene List<T>, IDictionary, etc.
using System.Linq;
using LinQ_Practice; // Habilita los métodos de extensión LINQ (Where, Select, OrderBy, ...)

class Producto
{
    // Propiedades automáticas: getter y setter público.
    // 'decimal' es recomendable para dinero porque evita errores de precisión de punto flotante.
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}

class Program
{
    static void Main()
    {
        // Inicialización de una lista in-memory de productos usando inicializadores de objetos.
        // 'var' infiere el tipo: List<Producto>.
        var productos = new List<Producto>
        {
            new Producto { Nombre = "Teclado", Precio = 45 },
            new Producto { Nombre = "Mouse",  Precio = 25 },
            new Producto { Nombre = "Monitor",Precio = 150 },
            new Producto { Nombre = "Laptop", Precio = 950 },
            new Producto { Nombre = "USB",    Precio = 10 }
        };

        // Construcción de la consulta LINQ usando métodos de extensión:
        // 1) Where: filtra por condición (lambda p => p.Precio > 50)
        // 2) OrderBy: ordena por Nombre (lambda p => p.Nombre)
        // 3) Select: proyecta cada producto a un *objeto anónimo* con solo Nombre y Precio
        // IMPORTANTE: Estas llamadas son *diferidas* (deferred execution). No se ejecutan hasta que iteremos.
        var resultado = productos
            .Where(p => p.Precio > 50)                // Filtra: deja productos con precio mayor a 50
            .OrderBy(p => p.Nombre)                   // Ordena alfabéticamente por el nombre
            .Select(p => new { p.Nombre, p.Precio }); // Proyecta a un tipo anónimo (solo Nombre + Precio)

        // Aquí se itera sobre 'resultado'. La ejecución real de la consulta ocurre ahora.
        // El tipo de 'p' dentro del foreach es el tipo anónimo creado por Select.
        foreach (var p in resultado)
        {
            // Interpolación de cadenas: inserta valores dentro de la cadena.
            // El '$' fuera de la interpolación es un carácter literal, no confundir con cifrado.
            Console.WriteLine($"{p.Nombre} - ${p.Precio}");
        }
        
        Console.WriteLine("=== Ejemplo de LINQ básico ===\n");
            
        // Invocamos el método de la clase LinqDemo
        LinQ2.LinqDemo.EjecutarEjemplo();
            
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}