using SalesProject.Domain.Models;
using System.Linq.Expressions;

namespace SalesProject.Domain.Queries;

public static class AdminQueries
{
    public static Expression<Func<Admin, bool>> GetById(Guid id) => admin => admin.Id == id;
    public static Expression<Func<Admin, bool>> GetByName(string name) => admin => admin.Name == name;
    public static Expression<Func<Admin, bool>> GetByEmail(string email) => admin => admin.Email == email;
    public static Expression<Func<Admin, bool>> GetByRole(string role) => admin => admin.Role == role;
}
