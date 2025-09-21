using Objets_Models.Models;

namespace Objets_Models;

public class Program
{
    static void Main(string[] args)
    {
        //coleccion de productos
        var products = new List<Product>
        {
            new Product { id = 1, name = "Escudo del capita", price = 50000 },
            new Product { id = 2, name = "Lanza telarañas", price = 300 },
            new Product { id = 3, name = "Brazo de  Bucky Barnes", price = 8000 }
        };

        //Coleccion de Customers
        var customers = new List<Customer>
        {
            new Customer {id = 1, name = "Andres David", email = "adres.david@riwi.io"},
            new Customer {id = 2, name = "Peter Parker", email = "peter.parker@spiderma.com"},
            new Customer{id = 3, name = "Rocket Racoon", email = "rocket.racoon@guardian.com"}
        };
        
        //Coleccion de Order
        var orders = new List<Order>
        {
            new Order { id = 1, CustomerId = 2, ProductId = 2, quantity = 2 },
            new Order { id = 2, CustomerId = 1, ProductId = 1, quantity = 1 },
            new Order { id = 3, CustomerId = 3, ProductId = 3, quantity = 1 },
        };
        
        //LINQ
        //LINQ funcion anonima
        // var query = from p in products where p.price > 1500 select p;
        //
        // foreach (var order in query)
        // {
        //     Console.WriteLine(order.name);
        // }
        //
        //
        // //LINQ lambda
        // var queryLambda = products.Where(p => p.price > 1500);
        //
        // foreach (var order in queryLambda)
        // {
        //     Console.WriteLine(order.name);
        // }
        //
        // //cientes
        // var clientesQ = from c in customers select c;
        //
        // foreach (var customer in clientesQ)
        // {
        //     Console.WriteLine(customer.name);
        // }
        //
        // var clientesLambda = customers.Select(c => c);
        //
        // foreach (var customer in clientesLambda)
        // {
        //     Console.WriteLine(customer.email);
        // }
        
        // //verificar que todos los productos sean mayor a 400
        // bool verified = products.All(p => p.price > 400);
        // Console.WriteLine($"Los productos valen mas de 400?; {verified}");
        //     
        // // Estado de los correos
        // bool emailState = customers.All(c => c.email.Contains("@gmail.com"));
        // Console.WriteLine($"Los clientes tienen correo: {emailState}");
        //
        // bool emailStateN = customers.All(c => c.email != null);
        // Console.WriteLine($"Los clientes tienen correo: {emailStateN}");

        var ids = customers.Select(p => p.id);
        bool state = ids.Contains(3);
        Console.WriteLine(state);
        
        //Joins, cunsultas avanzadas SQL
        var ordenes = from o in orders
            join c in customers on o.CustomerId equals c.id
            join p in products on o.CustomerId equals p.id
            select new
            {
                o.id, c.name,precioP = p.price, o.quantity
            };

        foreach (var ord in ordenes)
        {
            Console.WriteLine(ord);
        }

    }
}