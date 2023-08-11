namespace SalesProject.Domain.Models;

public class Product
{
    public Product(string name, string description, decimal price, int amount, string tag)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
        Amount = amount;
        Tag = tag;
        Clients = new List<Client>();
    }

    public Guid Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public string Tag { get; set; }

    public ICollection<Client> Clients { get; set; }
}
