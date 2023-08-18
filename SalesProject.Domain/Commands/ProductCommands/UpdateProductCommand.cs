using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.ProductCommands;

public class UpdateProductCommand : ICommand
{
    public UpdateProductCommand() { }
    public UpdateProductCommand(Guid id, string name, string description, decimal price, string tag)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Tag = tag;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Tag { get; set; }
}
