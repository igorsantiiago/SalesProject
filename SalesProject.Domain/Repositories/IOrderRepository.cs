using SalesProject.Domain.Models;

namespace SalesProject.Domain.Repositories;

public interface IOrderRepository
{
    void Create(Order order);
    void Update(Order order);
    void Delete(Order order);
    Order GetById(Guid id);
    IEnumerable<Order> GetAll();
}
