using SalesProject.Domain.Infra.Data.Mappings;
using SalesProject.Domain.Models;
using System.Linq.Expressions;

namespace SalesProject.Domain.Queries;

public static class OrderQueries
{
    public static Expression<Func<Order, bool>> GetById(Guid id) => order => order.Id == id;
}


//SELECT op.OrderId, u.Name as UserName, r.Name as RoleName, op.ProductId, p.Name as ProductName, op.CreatedOn
//FROM OrderProducts op
//JOIN[Orders] o ON op.OrderId = o.Id
//JOIN[Users] u ON o.UserId = u.Id
//JOIN[Roles] r ON u.RoleId = r.Id
//JOIN[Products] p ON op.ProductId = p.Id