using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.ProductCommands;

public class DeleteProductCommand : ICommand
{
    public DeleteProductCommand() { }
    public DeleteProductCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
