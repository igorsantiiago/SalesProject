using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.RoleCommands;
using SalesProject.Domain.Handlers;
using SalesProject.Domain.Tests.Repositories;

namespace SalesProject.Domain.Tests.HandlersTests;

public class RoleHandlerTests
{
    private readonly CreateRoleCommand _validCreateRoleCommand = new("User", "User");
    private readonly CreateRoleCommand _invalidCreateRoleCommand = new("", "");

    private readonly UpdateRoleCommand _validUpdateRoleCommand = new(Guid.NewGuid(), "Admin", "admin");
    private readonly UpdateRoleCommand _invalidUpdateRoleCommand = new(Guid.NewGuid(), "", "testando");

    private readonly DeleteRoleCommand _validDeleteRoleCommand = new(Guid.NewGuid());

    private readonly RoleHandler _handler = new(new FakeRoleRepository());

    public RoleHandlerTests() { }

    [Fact]
    public void Should_Create_Role_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validCreateRoleCommand);
        Assert.True(result.Success);
    }

    [Fact]
    public void Should_Fail_When_Create_Role_Command_Is_Invalid()
    {
        var result = (GenericCommandResult)_handler.Handle(_invalidCreateRoleCommand);
        Assert.False(result.Success);
    }

    [Fact]
    public void Should_Update_Role_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validUpdateRoleCommand);
        Assert.True(result.Success);
    }

    [Fact]
    public void Should_Fail_When_Update_Role_Command_Is_Invalid()
    {
        var result = (GenericCommandResult)_handler.Handle(_invalidUpdateRoleCommand);
        Assert.False(result.Success);
    }

    [Fact]
    public void Should_Delete_Role_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validDeleteRoleCommand);
        Assert.True(result.Success);
    }
}
