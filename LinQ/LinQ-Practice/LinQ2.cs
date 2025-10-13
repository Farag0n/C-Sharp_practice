using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ_Practice;

public class LinQ2
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }
    }

    public class LinqDemo
    {
        public static void EjecutarEjemplo()
        {
            // Lista de personas (simula una tabla en base de datos)
            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Ana", Edad = 25, Ciudad = "Bogotá" },
                new Persona { Nombre = "Luis", Edad = 30, Ciudad = "Medellín" },
                new Persona { Nombre = "Carla", Edad = 22, Ciudad = "Cali" },
                new Persona { Nombre = "Pedro", Edad = 28, Ciudad = "Bogotá" },
                new Persona { Nombre = "Lucía", Edad = 19, Ciudad = "Barranquilla" }
            };

            // 🔍 Ejemplo 1: Filtrar mayores de 25 años
            var mayoresDe25 = personas.Where(p => p.Edad > 25);

            Console.WriteLine("Personas mayores de 25 años:");
            foreach (var persona in mayoresDe25)
                Console.WriteLine($"{persona.Nombre} ({persona.Edad})");

            Console.WriteLine("\n---------------------------");

            // 🔍 Ejemplo 2: Ordenar por edad (ascendente)
            var ordenadasPorEdad = personas.OrderBy(p => p.Edad);

            Console.WriteLine("Personas ordenadas por edad:");
            foreach (var persona in ordenadasPorEdad)
                Console.WriteLine($"{persona.Nombre} ({persona.Edad})");

            Console.WriteLine("\n---------------------------");

            // 🔍 Ejemplo 3: Seleccionar solo nombres de quienes viven en Bogotá
            var nombresBogota = personas
                .Where(p => p.Ciudad == "Bogotá")
                .Select(p => p.Nombre);

            Console.WriteLine("Personas que viven en Bogotá:");
            foreach (var nombre in nombresBogota)
                Console.WriteLine(nombre);
        }
    }
}