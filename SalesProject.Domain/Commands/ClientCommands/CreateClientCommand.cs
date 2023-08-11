using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Commands.ClientCommands;

public class CreateClientCommand : ICommand
{
    public CreateClientCommand() { }
    public CreateClientCommand(string name, string email, string phoneNumber)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}
