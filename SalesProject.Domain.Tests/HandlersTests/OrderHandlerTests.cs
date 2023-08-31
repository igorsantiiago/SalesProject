using SalesProject.Domain.Handlers;
using SalesProject.Domain.Repositories;
using SalesProject.Domain.Tests.Repositories;

namespace SalesProject.Domain.Tests.HandlersTests;

public class OrderHandlerTests
{
    private readonly OrderHandler _handler = new(new FakeOrderRepository());

    public OrderHandlerTests() { }


}
