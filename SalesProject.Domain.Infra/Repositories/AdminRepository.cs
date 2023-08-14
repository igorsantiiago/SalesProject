using Microsoft.EntityFrameworkCore;
using SalesProject.Domain.Infra.Data;
using SalesProject.Domain.Models;
using SalesProject.Domain.Queries;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Infra.Repositories;

public class AdminRepository : IAdminRepository
{
    private readonly SalesProjectDbContext _context;

    public AdminRepository(SalesProjectDbContext context)
    {
        _context = context;
    }

    public void Create(Admin admin)
    {
        _context.Admins.Add(admin);
        _context.SaveChanges();
    }

    public void Delete(Admin admin)
    {
        _context.Admins.Remove(admin);
        _context.SaveChanges();
    }

    public void Update(Admin admin)
    {
        _context.Entry(admin).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public IEnumerable<Admin> GetAll() => _context.Admins.AsNoTracking().ToList();

    public IEnumerable<Admin> GetByEmail(string email) => _context.Admins.AsNoTracking().Where(AdminQueries.GetByEmail(email));

    public Admin GetById(Guid id)
    {
        Admin? admin = _context.Admins.FirstOrDefault(AdminQueries.GetById(id));
        return admin!;
    }

    public IEnumerable<Admin> GetByName(string name) => _context.Admins.AsNoTracking().Where(AdminQueries.GetByName(name));

    public IEnumerable<Admin> GetByRole(string role) => _context.Admins.AsNoTracking().Where(AdminQueries.GetByRole(role));
}
