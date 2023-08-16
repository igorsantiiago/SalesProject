using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.OrderCommands;

public class AddProductOrderCommand : ICommand
{
    public AddProductOrderCommand() { }
    public AddProductOrderCommand(Guid orderId, Guid productId)
    {
        OrderId = orderId;
        ProductId = productId;
    }

    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
}
