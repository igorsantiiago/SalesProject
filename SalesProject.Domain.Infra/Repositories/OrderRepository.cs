using Microsoft.EntityFrameworkCore;
using SalesProject.Domain.Infra.Data;
using SalesProject.Domain.Models;
using SalesProject.Domain.Queries;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Infra.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly SalesProjectDbContext _context;

    public OrderRepository(SalesProjectDbContext context)
    {
        _context = context;
    }

    public void Create(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }

    public void Update(Order order)
    {
        _context.Entry(order).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(Order order)
    {
        _context.Orders.Remove(order);
        _context.SaveChanges();
    }

    public void AddProduct(Order order, Product product)
    {
        order.Products.Add(product);
        _context.Entry(order).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void RemoveProduct(Order order, Product product) 
    {
        var orderProduct = _context.OrderProducts.Single(x => x.OrderId == order.Id && x.ProductId == product.Id);
        _context.OrderProducts.Remove(orderProduct);
        _context.SaveChanges();
    }

    public IEnumerable<Order> GetAll()
    {
        return _context.Orders.AsNoTracking().ToList();
    }

    public Order GetById(Guid id)
    {
        var order = _context.Orders.FirstOrDefault(OrderQueries.GetById(id));
        return order!;
    }
}
