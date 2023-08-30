using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Models;

public class Product
{
    public Product(string name, string description, decimal price, string tag)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
        Tag = tag;

        Orders = new List<Order>();
        OrderProducts = new List<OrderProduct>();
    }

    public Guid Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Tag { get; set; }

    public ICollection<Order> Orders { get; set; }
    public ICollection<OrderProduct> OrderProducts { get; set; }

}
