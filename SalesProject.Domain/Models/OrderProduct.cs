namespace SalesProject.Domain.Infra.Data.Mappings;

public class OrderProduct
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public DateTime CreatedOn { get; set; }
}
