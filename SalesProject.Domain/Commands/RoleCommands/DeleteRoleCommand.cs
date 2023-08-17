using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.RoleCommands;

public class DeleteRoleCommand : ICommand
{
    public DeleteRoleCommand() { }
    public DeleteRoleCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
