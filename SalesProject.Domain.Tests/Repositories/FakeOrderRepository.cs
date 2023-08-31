using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Tests.Repositories;

public class FakeOrderRepository : IOrderRepository
{
    public FakeOrderRepository()
    {
        
    }
    private readonly static Role _role = new("User", "user");
    private readonly User _user = new("Balta", "balta@balta.io", "00000000000", "A-0U98FD87HYfdsa98h7yn", _role.Id);
    public void Create(Order order) { }

    public void Delete(Order order) { }

    public void Update(Order order) { }

    public IEnumerable<Order> GetAll()
    {
        throw new NotImplementedException();
    }

    public Order GetById(Guid id) => new(_user.Id);
}
