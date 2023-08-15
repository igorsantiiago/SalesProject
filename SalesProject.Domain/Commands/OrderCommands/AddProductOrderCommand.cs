using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.OrderCommands;

public class AddProductOrderCommand : ICommand
{
    public AddProductOrderCommand() { }
    public AddProductOrderCommand(Guid id, Guid productId)
    {
        Id = id;
        ProductId = productId;
    }

    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
}
