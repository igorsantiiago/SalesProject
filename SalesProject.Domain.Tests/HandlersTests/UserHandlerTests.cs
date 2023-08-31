using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.UserCommands;
using SalesProject.Domain.Handlers;
using SalesProject.Domain.Models;
using SalesProject.Domain.Tests.Repositories;
using System.Data;

namespace SalesProject.Domain.Tests.HandlersTests;

public class UserHandlerTests
{
    private static Role _role = new("User", "user");
    private readonly CreateUserCommand _validCreateUserCommand = new("Balta", "balta@balta.io", "00000000000", "A-0U98FD87HYfdsa98h7yn", _role.Id);
    private readonly CreateUserCommand _invalidCreateUserCommand = new("","","","", _role.Id);

    private readonly UpdateUserCommand _validUpdateUserCommand = new(Guid.NewGuid(), "David", "david@harvard.com", "11111111111", "B-0U98FD87HYfdsa98h7yn", _role.Id);
    private readonly UpdateUserCommand _invalidUpdateUserCommand = new(Guid.NewGuid(), "", "", "11111111111", "B-0U98FD87HYfdsa98h7yn", _role.Id);

    private readonly DeleteUserCommand _validDeleteUserCommand = new(Guid.NewGuid());

    private readonly UserHandler _handler = new(new FakeUserRepository());

    public UserHandlerTests() { }

    [Fact]
    public void Should_Create_User_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validCreateUserCommand);
        Assert.True(result.Success);
    }

    [Fact]
    public void Should_Fail_When_Create_User_Command_Is_Invalid()
    {
        var result = (GenericCommandResult)_handler.Handle(_invalidCreateUserCommand);
        Assert.False(result.Success);
    }

    [Fact]
    public void Should_Update_User_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validUpdateUserCommand);
        Assert.True(result.Success);
    }

    [Fact]
    public void Should_Fail_When_Update_User_Command_Is_Invalid()
    {
        var result = (GenericCommandResult)_handler.Handle(_invalidUpdateUserCommand);
        Assert.False(result.Success);
    }

    [Fact]
    public void Should_Delete_User_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validDeleteUserCommand);
        Assert.True(result.Success);
    }
}
