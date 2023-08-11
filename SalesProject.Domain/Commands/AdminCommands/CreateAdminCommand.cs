using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.AdminCommands;

public class CreateAdminCommand : ICommand
{
    public CreateAdminCommand() { }
    public CreateAdminCommand(string name, string email, string passwordHash)
    {
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
}
