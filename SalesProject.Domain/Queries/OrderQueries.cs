using SalesProject.Domain.Models;
using System.Linq.Expressions;

namespace SalesProject.Domain.Queries;

public static class OrderQueries
{
    public static Expression<Func<Order, bool>> GetById(Guid id) => order => order.Id == id;
}
