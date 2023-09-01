using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Commands.OrderCommands;

public class CreateOrderCommand : ICommand
{
    protected CreateOrderCommand() { }
    public CreateOrderCommand(Guid userId)
    {
        UserId = userId;
    }

    [Required(ErrorMessage = "Insira o Id do usuário!")]
    public Guid UserId { get; set; }
}
