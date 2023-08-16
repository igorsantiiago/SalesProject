using Microsoft.EntityFrameworkCore;
using SalesProject.Domain.Infra.Data;
using SalesProject.Domain.Models;
using SalesProject.Domain.Queries;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Infra.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly SalesProjectDbContext _context;

    public ProductRepository(SalesProjectDbContext context)
    {
        _context = context;
    }

    public void Create(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void Delete(Product product)
    {
        _context.Products.Remove(product);
        _context.SaveChanges();
    }

    public void Update(Product product)
    {
        _context.Entry(product).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public IEnumerable<Product> GetAll() => _context.Products.AsNoTracking().ToList();

    public Product GetById(Guid id)
    {
        Product? product = _context.Products.FirstOrDefault(ProductQueries.GetById(id));
        return product!;
    }

    public IEnumerable<Product> GetByName(string name) => _context.Products.AsNoTracking().Where(ProductQueries.GetByName(name)).ToList();

    public IEnumerable<Product> GetByTag(string tag) => _context.Products.AsNoTracking().Where(ProductQueries.GetByTag(tag)).ToList();
}
