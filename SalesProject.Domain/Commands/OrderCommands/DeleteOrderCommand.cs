using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Commands.OrderCommands;

public class DeleteOrderCommand : ICommand
{
    protected DeleteOrderCommand() { }
    public DeleteOrderCommand(Guid id)
    {
        Id = id;
    }

    [Required(ErrorMessage = "Insira o Id do pedido a ser removido!")]
    public Guid Id { get; set; }
}
