using SalesProject.Domain.Infra.Data.Mappings;
using System.Text.Json.Serialization;

namespace SalesProject.Domain.Models;

public class Order
{
    public Order(Guid clientId)
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        ClientId = clientId;

        Products = new List<Product>();
        OrderProducts = new List<OrderProduct>();
    }

    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal TotalPrice { get; set; }
    public Guid ClientId { get; set; }
    public Client Client { get; set; }


    public ICollection<Product> Products { get; set; }
    public ICollection<OrderProduct> OrderProducts{ get; set; }


    public void CalculateTotalPriceAfterAddingProduct()
    {
        foreach (var product in Products)
        {
            TotalPrice += product.Price;
        }
    }

    public void CalculateTotalPriceAfterRemovingProduct()
    {
        foreach (var product in Products)
        {
            TotalPrice -= product.Price;
        }
    }
}
