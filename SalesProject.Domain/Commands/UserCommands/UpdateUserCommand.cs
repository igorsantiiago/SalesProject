using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.UserCommands;

public class UpdateUserCommand : ICommand
{
    public UpdateUserCommand() { }
    public UpdateUserCommand(Guid id, string name, string email, string phoneNumber, string passwordHash, Guid roleId)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        PasswordHash = passwordHash;
        RoleId = roleId;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string PasswordHash { get; set; }

    public Guid RoleId { get; set; }
}
