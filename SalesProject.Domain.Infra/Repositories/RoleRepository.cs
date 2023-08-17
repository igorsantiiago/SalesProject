using Microsoft.EntityFrameworkCore;
using SalesProject.Domain.Infra.Data;
using SalesProject.Domain.Models;
using SalesProject.Domain.Queries;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Infra.Repositories;

public class RoleRepository : IRoleRepository
{
    private readonly SalesProjectDbContext _context;

    public RoleRepository(SalesProjectDbContext context)
    {
        _context = context;
    }

    public void Create(Role role)
    {
        _context.Roles.Add(role);
        _context.SaveChanges();
    }

    public void Delete(Role role)
    {
        _context.Roles.Remove(role);
        _context.SaveChanges();
    }

    public void Update(Role role)
    {
        _context.Entry(role).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public IEnumerable<Role> GetAll() => _context.Roles.AsNoTracking().ToList();

    public Role GetById(Guid id)
    {
        var role = _context.Roles.FirstOrDefault(RoleQueries.GetById(id));
        return role!;
    }

    public IEnumerable<Role> GetByName(string name) => _context.Roles.AsNoTracking().Where(RoleQueries.GetByName(name)).ToList();

    public IEnumerable<Role> GetBySlug(string slug) => _context.Roles.AsNoTracking().Where(RoleQueries.GetBySlug(slug)).ToList();
}
