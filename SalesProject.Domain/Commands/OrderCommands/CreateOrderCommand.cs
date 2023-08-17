using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.OrderCommands;

public class CreateOrderCommand : ICommand
{
    public CreateOrderCommand() { }
    public CreateOrderCommand(Guid userId)
    {
        UserId = userId;
    }

    public Guid UserId { get; set; }
}
