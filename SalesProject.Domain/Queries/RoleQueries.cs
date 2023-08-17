using SalesProject.Domain.Models;
using System.Linq.Expressions;

namespace SalesProject.Domain.Queries;

public static class RoleQueries
{
    public static Expression<Func<Role, bool>> GetById(Guid id) => role => role.Id == id;
    public static Expression<Func<Role, bool>> GetByName(string name) => role => role.Name == name;
    public static Expression<Func<Role, bool>> GetBySlug(string slug) => role => role.Slug == slug;
}
