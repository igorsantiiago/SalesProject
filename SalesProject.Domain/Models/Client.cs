using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Models;

public class Client
{
    public Client(string name, string email, string phoneNumber)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Products = new List<Product>();
    }

    public Guid Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public ICollection<Product> Products { get; set; }

    public void AddProduct(List<Product> products)
    {
        foreach(var product in products)
        {
            Products.Add(product);
        }
    }
}
