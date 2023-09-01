using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Commands.ProductCommands;

public class DeleteProductCommand : ICommand
{
    protected DeleteProductCommand() { }
    public DeleteProductCommand(Guid id)
    {
        Id = id;
    }

    [Required(ErrorMessage = "Insira a Id do produto!")]
    public Guid Id { get; set; }
}
