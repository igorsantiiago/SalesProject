using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Commands.RoleCommands;

public class UpdateRoleCommand : ICommand
{
    public UpdateRoleCommand() { }
    public UpdateRoleCommand(Guid id, string name, string slug)
    {
        Id = id;
        Name = name;
        Slug = slug;
    }

    [Required(ErrorMessage = "Insira o Id da atribuição!")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Insira o nome da atribuição!")]
    [StringLength(80, MinimumLength = 3, ErrorMessage = "O nome da atribuição precisa conter no mínimo 3 caracteres e no máximo 80 caracteres.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Insira o slug da atribuição!")]
    [StringLength(80, MinimumLength = 3, ErrorMessage = "O slug da atribuição precisa conter no mínimo 3 caracteres e no máximo 80 caracteres.")]
    public string Slug { get; set; }
}
