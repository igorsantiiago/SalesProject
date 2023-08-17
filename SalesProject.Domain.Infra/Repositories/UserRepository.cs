using Microsoft.EntityFrameworkCore;
using SalesProject.Domain.Infra.Data;
using SalesProject.Domain.Models;
using SalesProject.Domain.Queries;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Infra.Repositories;

public class UserRepository : IUserRepository
{
    private readonly SalesProjectDbContext _context;

    public UserRepository(SalesProjectDbContext context)
    {
        _context = context;
    }

    public void Create(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public void Delete(User user)
    {
        _context.Users.Remove(user);
        _context.SaveChanges();
    }

    public void Update(User user)
    {
        _context.Entry(user).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void AddProduct(User user)
    {
        _context.Entry(user).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public IEnumerable<User> GetAll() => _context.Users.AsNoTracking().ToList();

    public IEnumerable<User> GetByEmail(string email) => _context.Users.AsNoTracking().Where(UserQueries.GetByEmail(email));

    public User GetById(Guid id)
    {
        User? user = _context.Users.AsNoTracking().FirstOrDefault(UserQueries.GetById(id));
        return user!;
    }

    public IEnumerable<User> GetByName(string name) => _context.Users.AsNoTracking().Where(UserQueries.GetByName(name));
}
