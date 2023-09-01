using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.OrderCommands;
using SalesProject.Domain.Commands.ProductCommands;
using SalesProject.Domain.Handlers;
using SalesProject.Domain.Models;
using SalesProject.Domain.Tests.Repositories;

namespace SalesProject.Domain.Tests.HandlersTests;

public class OrderHandlerTests
{
    private static Role _userRole = new("User", "user");
    private static User _user = new("Andre Baltieri", "balta@balta.io", "00000000000", "FSDA09yh87n-0I", _userRole.Id);

    private readonly CreateOrderCommand _validCreateOrder = new(_user.Id);
    private readonly CreateOrderCommand _invalidCreateOrder = new(Guid.Empty);

    private readonly UpdateOrderCommand _validUpdateOrder = new(Guid.NewGuid(), _user.Id);
    private readonly UpdateOrderCommand _invalidUpdateOrder = new(Guid.NewGuid(), Guid.Empty);

    private readonly DeleteOrderCommand _validDeleteOrder = new(Guid.NewGuid());

    private readonly OrderHandler _handler = new(new FakeOrderRepository());

    public OrderHandlerTests() 
    {
    }

    [Fact]
    public void Should_Create_Order_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validCreateOrder);
        Assert.True(result.Success);
    }

    [Fact]
    public void Should_Fail_When_Create_Order_Command_Is_Invalid()
    {
        var result = (GenericCommandResult)_handler.Handle(_invalidCreateOrder);
        Assert.False(result.Success);
    }

    [Fact]
    public void Should_Update_Order_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validUpdateOrder);
        Assert.True(result.Success);
    }

    [Fact]
    public void Should_Fail_When_Update_Order_Command_Is_Invalid()
    {
        var result = (GenericCommandResult)_handler.Handle(_invalidUpdateOrder);
        Assert.False(result.Success);
    }

    [Fact]
    public void Should_Delete_Order_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validDeleteOrder);
        Assert.True(result.Success);
    }

}
