using SalesProject.Domain.Commands.Contracts;

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

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
}
