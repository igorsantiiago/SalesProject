namespace SalesProject.Domain.Models;

public class Client
{
    public Client(string name, string email, string phoneNumber)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public Guid Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public ICollection<Order> Orders { get; set; }
}
