using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.OrderCommands;

public class UpdateOrderCommand : ICommand
{
    public UpdateOrderCommand() { }
    public UpdateOrderCommand(Guid id, Guid clientId)
    {
        Id = id;
        ClientId = clientId;
    }

    public Guid Id { get; set; }
    public Guid ClientId { get; set; }

}
