namespace SalesProject.Domain.Models;

public class Product
{
    public Product(string name, string description, decimal price, int amout, string tag)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
        Amout = amout;
        Tag = tag;
    }

    public Guid Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Amout { get; set; }
    public string Tag { get; set; }
}
