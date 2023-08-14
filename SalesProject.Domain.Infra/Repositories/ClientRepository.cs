using Microsoft.EntityFrameworkCore;
using SalesProject.Domain.Infra.Data;
using SalesProject.Domain.Models;
using SalesProject.Domain.Queries;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Infra.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly SalesProjectDbContext _context;

    public ClientRepository(SalesProjectDbContext context)
    {
        _context = context;
    }

    public void Create(Client client)
    {
        _context.Clients.Add(client);
        _context.SaveChanges();
    }

    public void Delete(Client client)
    {
        _context.Clients.Remove(client);
        _context.SaveChanges();
    }

    public IEnumerable<Client> GetAll() => _context.Clients.AsNoTracking().ToList();

    public IEnumerable<Client> GetByEmail(string email) => _context.Clients.AsNoTracking().Where(ClientQueries.GetByEmail(email));

    public Client GetById(Guid id)
    {
        Client? client = _context.Clients.AsNoTracking().FirstOrDefault(ClientQueries.GetById(id));
        return client!;
    }

    public IEnumerable<Client> GetByName(string name) => _context.Clients.AsNoTracking().Where(ClientQueries.GetByName(name));

    public void Update(Client client)
    {
        _context.Entry(client).State = EntityState.Modified;
        _context.SaveChanges();
    }
}
