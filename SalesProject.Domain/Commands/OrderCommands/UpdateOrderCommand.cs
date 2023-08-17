using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.OrderCommands;

public class UpdateOrderCommand : ICommand
{
    public UpdateOrderCommand() { }
    public UpdateOrderCommand(Guid id, Guid userId)
    {
        Id = id;
        UserId = userId;
    }

    public Guid Id { get; set; }
    public Guid UserId { get; set; }

}
