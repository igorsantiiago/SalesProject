using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.AdminCommands;

public class UpdateAdminCommand : ICommand
{
    public UpdateAdminCommand() { }
    public UpdateAdminCommand(Guid id, string name, string email, string passwordHash)
    {
        Id = id;
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
}
