using SalesProject.Domain.Commands.Contracts;
using SalesProject.Domain.Models;

namespace SalesProject.Domain.Commands.ClientCommands;

public class AddProductsClientCommand : ICommand
{
    public AddProductsClientCommand() { }
    public AddProductsClientCommand(Guid id, List<Product> products)
    {
        Id = id;
        Products = products;
    }

    public Guid Id { get; set; }
    public List<Product> Products { get; set; }
}
