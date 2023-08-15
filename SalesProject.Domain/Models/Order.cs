namespace SalesProject.Domain.Models;

public class Order
{
    public Order(Guid clientId)
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        ClientId = clientId;
    }

    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal TotalPrice { get; set; }
    public Guid ClientId { get; set; }

    public Client Client { get; set; }
    public ICollection<Product> Products { get; set; }


    public void TotalCost()
    {
        foreach(var product in Products)
        {
            TotalPrice += product.Price;
        }
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        Products.Remove(product);
    }
}
