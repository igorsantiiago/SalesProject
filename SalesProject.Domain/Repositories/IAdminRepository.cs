using SalesProject.Domain.Models;

namespace SalesProject.Domain.Repositories;

public interface IAdminRepository
{
    void Create(Admin admin);
    void Update(Admin admin);
    void Delete(Admin admin);
    Admin GetById(Guid id);
    IEnumerable<Admin> GetAll();
    IEnumerable<Admin> GetByName(string name);
    IEnumerable<Admin> GetByEmail(string email);
    IEnumerable<Admin> GetByRole(string role);

}
