using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Commands.UserCommands;

public class DeleteUserCommand : ICommand
{
    public DeleteUserCommand() { }
    public DeleteUserCommand(Guid id)
    {
        Id = id;
    }

    [Required(ErrorMessage = "Insira o Id do usuário!")]
    public Guid Id { get; set; }
}
