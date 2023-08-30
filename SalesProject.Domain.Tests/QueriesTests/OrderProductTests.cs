using SalesProject.Domain.Models;
using SalesProject.Domain.Queries;
using System.Security.Cryptography.X509Certificates;

namespace SalesProject.Domain.Tests.QueriesTests;

public class OrderProductTests
{
    private readonly User _validUser;
    private readonly List<Order> _validOrder;
    Role _userRole = new("User", "user");
    private Guid _validId;
    private Guid? _invalidId;

    public OrderProductTests()
    {
        _validUser = new("Andre Baltieri", "balta@balta.io", "00000000000", "FSDA09yh87n-0I", _userRole.Id);
        _validOrder = new List<Order>
        {
            new(_userRole.Id),
            new(_userRole.Id)
        };

        _validId = _validOrder[0].Id;
        _invalidId = null!;
    }

    [Fact]
    public void Should_Return_Order_When_Id_Is_Valid()
    {
        var result = _validOrder.AsQueryable().Where(OrderQueries.GetById(_validId));
        Assert.Equal(1, result.Count());
    }

    [Fact]
    public void Should_Return_Empty_When_Id_Does_Not_Exist()
    {
        var result = _validOrder.AsQueryable().Where(OrderQueries.GetById(_invalidId.GetValueOrDefault()));
        Assert.Empty(result);
    }
}
