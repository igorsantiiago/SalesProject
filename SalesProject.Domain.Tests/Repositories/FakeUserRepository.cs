using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Tests.Repositories;

public class FakeUserRepository : IUserRepository
{
    private Role role;
    public FakeUserRepository()
    {
        role = new Role("User", "user");
    }

    public void Create(User user) { }

    public void Delete(User user) { }

    public void Update(User user) { }

    public IEnumerable<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public User GetById(Guid id) => new("Balta", "balta@balta.io", "00000000000", "A-0U98FD87HYfdsa98h7yn", role.Id);

    public IEnumerable<User> GetByName(string name)
    {
        throw new NotImplementedException();
    }
}
