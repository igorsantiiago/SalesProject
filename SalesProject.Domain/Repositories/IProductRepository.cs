using SalesProject.Domain.Models;

namespace SalesProject.Domain.Repositories;

public interface IProductRepository
{
    void Create(Product product);
    void Update(Product product);
    void Delete(Product product);
    Product GetById(Guid id);
    IEnumerable<Product> GetAll();
    IEnumerable<Product> GetByName(string name);
    IEnumerable<Product> GetByTag(string tag);
}
