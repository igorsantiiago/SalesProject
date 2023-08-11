using SalesProject.Domain.Models;
using System.Linq.Expressions;

namespace SalesProject.Domain.Queries;

public static class ProductQueries
{
    public static Expression<Func<Product, bool>> GetById(Guid id) => product => product.Id == id;
    public static Expression<Func<Product, bool>> GetByName(string name) => product => product.Name == name;
    public static Expression<Func<Product, bool>> GetByTag(string tag) => product => product.Tag == tag;
}
