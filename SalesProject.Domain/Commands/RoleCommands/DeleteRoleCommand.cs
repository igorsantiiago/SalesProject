using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Commands.RoleCommands;

public class DeleteRoleCommand : ICommand
{
    protected DeleteRoleCommand() { }
    public DeleteRoleCommand(Guid id)
    {
        Id = id;
    }

    [Required(ErrorMessage = "Insira o Id da atribuição!")]
    public Guid Id { get; set; }
}
