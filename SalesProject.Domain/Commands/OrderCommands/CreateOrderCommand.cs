using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.OrderCommands;

public class CreateOrderCommand : ICommand
{
    public CreateOrderCommand() { }
    public CreateOrderCommand(Guid clientId)
    {
        ClientId = clientId;
    }

    public Guid ClientId { get; set; }
}
