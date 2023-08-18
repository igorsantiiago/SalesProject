namespace SalesProject.Domain.Models;

public class Order
{
    public Order(Guid userId)
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        UserId = userId;

        Products = new List<Product>();
        OrderProducts = new List<OrderProduct>();
    }

    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal TotalPrice { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }


    public ICollection<Product> Products { get; set; }
    public ICollection<OrderProduct> OrderProducts{ get; set; }


    public void CalculateTotalPriceAfterAddingProduct()
    {
        foreach (var product in Products)
        {
            TotalPrice += product.Price;
        }
    }

    public void CalculateTotalPriceAfterRemovingProduct()
    {
        foreach (var product in Products)
        {
            TotalPrice -= product.Price;
            if (TotalPrice <= 0)
                TotalPrice = 0;
        }
    }
}
