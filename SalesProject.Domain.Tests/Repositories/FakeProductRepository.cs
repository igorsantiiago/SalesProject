using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Tests.Repositories;

public class FakeProductRepository : IProductRepository
{
    public void Create(Product product) { }

    public void Delete(Product product) { }

    public void Update(Product product) { }

    public IEnumerable<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Product GetById(Guid id) => new("Clean", "Clean Test", 100, "book");

    public IEnumerable<Product> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetByTag(string tag)
    {
        throw new NotImplementedException();
    }
}
