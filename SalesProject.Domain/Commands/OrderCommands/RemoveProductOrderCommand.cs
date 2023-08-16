using SalesProject.Domain.Commands.Contracts;
using SalesProject.Domain.Models;

namespace SalesProject.Domain.Commands.OrderCommands;

public class RemoveProductOrderCommand : ICommand
{
    public RemoveProductOrderCommand() { }
    public RemoveProductOrderCommand(Guid orderId, Guid productId)
    {
        OrderId = orderId;
        ProductId = productId;
    }

    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
}
