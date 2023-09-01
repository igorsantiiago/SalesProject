using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Commands.UserCommands;

public class UpdateUserCommand : ICommand
{
    protected UpdateUserCommand() { }
    public UpdateUserCommand(Guid id, string name, string email, string phoneNumber, string passwordHash, Guid roleId)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        PasswordHash = passwordHash;
        RoleId = roleId;
    }

    [Required(ErrorMessage = "Insira o Id do usuário!")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Insira o nome do usuário!")]
    [StringLength(120, MinimumLength = 3)]
    public string Name { get; set; }

    [Required(ErrorMessage = "Insira o email do usuário!")]
    [StringLength(180, MinimumLength = 6)]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required(ErrorMessage = "Insira o número de telefone do usuário!")]
    [StringLength(32, MinimumLength = 8)]
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Insira a senha do usuário!")]
    [StringLength(255, MinimumLength = 8)]
    [DataType(DataType.Password)]
    public string PasswordHash { get; set; }

    [Required(ErrorMessage = "Insira o Id da atribuição do usuário!")]
    public Guid RoleId { get; set; }
}
