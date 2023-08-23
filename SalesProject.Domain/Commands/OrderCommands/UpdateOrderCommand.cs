using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Commands.OrderCommands;

public class UpdateOrderCommand : ICommand
{
    public UpdateOrderCommand() { }
    public UpdateOrderCommand(Guid id, Guid userId)
    {
        Id = id;
        UserId = userId;
    }


    [Required(ErrorMessage = "Insira o Id do pedido!")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Insira o Id do usuário!")]
    public Guid UserId { get; set; }

}
