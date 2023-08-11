using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.AdminCommands;

public class DeleteAdminCommand : ICommand
{
    public DeleteAdminCommand() { }
    public DeleteAdminCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
