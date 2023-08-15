using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.OrderCommands;

public class DeleteOrderCommand : ICommand
{
    public DeleteOrderCommand() { }
    public DeleteOrderCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
