namespace Objets_Models.Models;

public class Order
{
    public int id { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public int quantity { get; set; }
}