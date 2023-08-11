using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.AdminCommands;

public class CreateAdminCommand : ICommand
{
    public CreateAdminCommand() { }
    public CreateAdminCommand(string name, string email, string passwordHash, string role)
    {
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; }
}
