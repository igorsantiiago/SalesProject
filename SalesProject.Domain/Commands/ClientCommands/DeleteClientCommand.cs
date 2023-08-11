using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.ClientCommands;

public class DeleteClientCommand : ICommand
{
    public DeleteClientCommand() { }
    public DeleteClientCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
