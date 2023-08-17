using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.UserCommands;

public class DeleteUserCommand : ICommand
{
    public DeleteUserCommand() { }
    public DeleteUserCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
