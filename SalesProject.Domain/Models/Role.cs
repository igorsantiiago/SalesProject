namespace SalesProject.Domain.Models;

public class Role
{
    public Role(string name, string slug)
    {
        Id = Guid.NewGuid();
        Name = name;
        Slug = slug;

        Users = new List<User>();
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }

    public ICollection<User> Users { get; set; }
}
