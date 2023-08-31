using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Tests.Repositories;

public class FakeRoleRepository : IRoleRepository
{
    public void Create(Role role) { }

    public void Delete(Role role) { }

    public void Update(Role role) { }

    public IEnumerable<Role> GetAll()
    {
        throw new NotImplementedException();
    }

    public Role GetById(Guid id) => new("Teste", "teste");

    public IEnumerable<Role> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Role> GetBySlug(string slug)
    {
        throw new NotImplementedException();
    }

}
