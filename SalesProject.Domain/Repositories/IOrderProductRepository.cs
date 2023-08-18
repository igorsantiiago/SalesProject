using SalesProject.Domain.Models;

namespace SalesProject.Domain.Repositories;

public interface IOrderProductRepository
{
    OrderProduct GetOrderProduct(Order order, Product product);
}
