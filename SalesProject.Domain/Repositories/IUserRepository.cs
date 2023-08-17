using SalesProject.Domain.Models;

namespace SalesProject.Domain.Repositories;

public interface IUserRepository
{
    void Create(User user);
    void Update(User user);
    void Delete(User user);
    User GetById(Guid id);
    IEnumerable<User> GetAll();
    IEnumerable<User> GetByName(string name);
    IEnumerable<User> GetByEmail(string email);

}
