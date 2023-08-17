using SalesProject.Domain.Models;
using System.Linq.Expressions;

namespace SalesProject.Domain.Queries;

public static class UserQueries
{
    public static Expression<Func<User, bool>> GetById(Guid id) => user => user.Id == id;
    public static Expression<Func<User, bool>> GetByName(string name) => user => user.Name == name;
    public static Expression<Func<User, bool>> GetByEmail(string email) => user => user.Email == email;
}
