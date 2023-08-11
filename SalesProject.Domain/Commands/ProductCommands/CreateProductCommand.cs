using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.ProductCommands;

public class CreateProductCommand : ICommand
{
    public CreateProductCommand() { }
    public CreateProductCommand(string name, string description, decimal price, int amount, string tag)
    {
        Name = name;
        Description = description;
        Price = price;
        Amount = amount;
        Tag = tag;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public string Tag { get; set; }
}
