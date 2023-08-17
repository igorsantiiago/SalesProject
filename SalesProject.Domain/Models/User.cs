namespace SalesProject.Domain.Models;

public class User
{
    public User(string name, string email, string phoneNumber, string passwordHash, Guid roleId)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        PasswordHash = passwordHash;
        RoleId = roleId;
    }

    public Guid Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public string PasswordHash { get; set; }

    public Guid RoleId { get; set; }
    public Role Role { get; set; }

    public ICollection<Order> Orders { get; set; }
}
