using SalesProject.Domain.Models;

namespace SalesProject.Domain.Repositories;

public interface IClientRepository
{
    void Create(Client client);
    void Update(Client client);
    void Delete(Client client);
    Client GetById(Guid id);
    IEnumerable<Client> GetAll();
    IEnumerable<Client> GetByName(string name);
    IEnumerable<Client> GetByEmail(string email);

}
