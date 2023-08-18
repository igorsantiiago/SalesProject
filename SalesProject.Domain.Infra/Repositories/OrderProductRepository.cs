using SalesProject.Domain.Infra.Data;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Infra.Repositories;

public class OrderProductRepository : IOrderProductRepository
{
    private readonly SalesProjectDbContext _context;

    public OrderProductRepository(SalesProjectDbContext context)
    {
        _context = context;
    }

    public OrderProduct GetOrderProduct(Order order, Product product)
    {
        var orderProduct = _context.OrderProducts.Single(x => x.OrderId == order.Id && x.ProductId == product.Id);
        return orderProduct!;
    }
}
