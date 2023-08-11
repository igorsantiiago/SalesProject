using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.ClientCommands;

public class UpdateClientCommand : ICommand
{
    public UpdateClientCommand() { }
    public UpdateClientCommand(Guid id, string name, string email, string phoneNumber)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}
