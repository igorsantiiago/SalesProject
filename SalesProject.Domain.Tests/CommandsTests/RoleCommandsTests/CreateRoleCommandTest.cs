using SalesProject.Domain.Commands.RoleCommands;

namespace SalesProject.Domain.Tests.CommandsTests.RoleCommandsTests;

public class CreateRoleCommandTest
{
    private readonly CreateRoleCommand _validCommand = new("User", "user");
    private readonly CreateRoleCommand _invalidCommand = new("", "");

    [Fact]
    public void Given_invalid_command()
    {

    }
}
