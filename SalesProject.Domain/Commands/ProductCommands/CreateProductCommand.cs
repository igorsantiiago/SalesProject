using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.ProductCommands;

public class CreateProductCommand : ICommand
{
    public CreateProductCommand() { }
    public CreateProductCommand(string name, string description, decimal price, string tag)
    {
        Name = name;
        Description = description;
        Price = price;
        Tag = tag;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Tag { get; set; }
}
