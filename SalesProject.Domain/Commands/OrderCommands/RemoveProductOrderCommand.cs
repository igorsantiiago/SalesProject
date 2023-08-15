using SalesProject.Domain.Commands.Contracts;
using SalesProject.Domain.Models;

namespace SalesProject.Domain.Commands.OrderCommands;

public class RemoveProductOrderCommand : ICommand
{
    public RemoveProductOrderCommand() { }
    public RemoveProductOrderCommand(Guid id, Guid productId)
    {
        Id = id;
        ProductId = productId;
    }

    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
}
