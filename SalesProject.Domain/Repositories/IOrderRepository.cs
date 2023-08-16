using SalesProject.Domain.Models;

namespace SalesProject.Domain.Repositories;

public interface IOrderRepository
{
    void Create(Order order);
    void Update(Order order);
    void Delete(Order order);
    void AddProduct(Order order, Product product);
    void RemoveProduct(Order order, Product product);
    Order GetById(Guid id);
    IEnumerable<Order> GetAll();
}
