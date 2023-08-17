using SalesProject.Domain.Models;

namespace SalesProject.Domain.Repositories;

public interface IRoleRepository
{
    void Create(Role role);
    void Update(Role role);
    void Delete(Role role);
    Role GetById(Guid id);
    IEnumerable<Role> GetAll();
    IEnumerable<Role> GetByName(string name);
    IEnumerable<Role> GetBySlug(string slug);
}
