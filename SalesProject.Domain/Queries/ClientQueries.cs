using SalesProject.Domain.Models;
using System.Linq.Expressions;

namespace SalesProject.Domain.Queries;

public static class ClientQueries
{
    public static Expression<Func<Client, bool>> GetById(Guid id) => client => client.Id == id;
    public static Expression<Func<Client, bool>> GetByName(string name) => client => client.Name == name;
    public static Expression<Func<Client, bool>> GetByEmail(string email) => client => client.Email == email;
}
