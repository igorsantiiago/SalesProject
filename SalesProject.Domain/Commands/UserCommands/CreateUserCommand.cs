using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.UserCommands;

public class CreateUserCommand : ICommand
{
    public CreateUserCommand() { }
    public CreateUserCommand(string name, string email, string phoneNumber, string passwordHash, Guid roleId)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        PasswordHash = passwordHash;
        RoleId = roleId;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string PasswordHash { get; set; }

    public Guid RoleId { get; set; }
}
