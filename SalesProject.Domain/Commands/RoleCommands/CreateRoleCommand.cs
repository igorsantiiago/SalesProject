using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.RoleCommands;

public class CreateRoleCommand : ICommand
{
    public CreateRoleCommand() { }
    public CreateRoleCommand(string name, string slug)
    {
        Name = name;
        Slug = slug;
    }

    public string Name { get; set; }
    public string Slug { get; set; }
}
