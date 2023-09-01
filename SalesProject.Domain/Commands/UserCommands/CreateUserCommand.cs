using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Commands.UserCommands;

public class CreateUserCommand : ICommand
{
    protected CreateUserCommand() { }
    public CreateUserCommand(string name, string email, string phoneNumber, string passwordHash, Guid roleId)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        PasswordHash = passwordHash;
        RoleId = roleId;
    }

    [Required(ErrorMessage = "Insira o nome do usuário!")]
    [StringLength(120, MinimumLength = 3, ErrorMessage = "O nome do usuário precisa conter no mínimo 3 caracteres e no máximo 120 caracteres.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Insira o email do usuário!")]
    [StringLength(180, MinimumLength = 6, ErrorMessage = "O email precisa conter no mínimo 6 caracteres e no máximo 180 caracteres.")]
    [DataType(DataType.EmailAddress,  ErrorMessage = "Insira um email válido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Insira o número de telefone do usuário!")]
    [StringLength(32, MinimumLength = 8, ErrorMessage = "O número de telefone precisa conter no mínimo 8 caracteres e no máximo 32 caracteres.")]
    [DataType(DataType.PhoneNumber, ErrorMessage = "Insira um número de telefone válido.")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Insira a senha do usuário!")]
    [StringLength(255, MinimumLength = 8, ErrorMessage = "A senha precisa conter no mínimo 8 caracteres e no máximo 255 caracteres.")]
    [DataType(DataType.Password)]
    public string PasswordHash { get; set; }

    [Required(ErrorMessage = "Insira o Id da atribuição do usuário!")]
    public Guid RoleId { get; set; }
}
