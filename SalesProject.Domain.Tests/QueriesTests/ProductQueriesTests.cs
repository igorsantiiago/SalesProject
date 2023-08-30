using SalesProject.Domain.Models;
using SalesProject.Domain.Queries;

namespace SalesProject.Domain.Tests.QueriesTests;

public class ProductQueriesTests
{
    private readonly List<Product> _validProducts;
    private readonly Guid _validId;
    private readonly Guid? _invalidId;

    public ProductQueriesTests()
    {
        _validProducts = new List<Product>
        {
            new("Clean Code", "Livro Clean Code", 89, "books"),
            new("S23", "Samsung S23", 3999, "eletronics"),
            new("Clean Architecture", "Livro Clean Architecture", 99, "books")
        };

        _validId = _validProducts[0].Id;
        _invalidId = null!;
    }

    [Fact]
    public void Should_Return_Product_When_Id_Is_Valid()
    {
        var result = _validProducts.AsQueryable().Where(ProductQueries.GetById(_validId));
        Assert.Equal(1, result.Count());
    }
    
    [Fact]
    public void Should_Return_Empty_When_Id_Does_Not_Exists()
    {
        var result = _validProducts.AsQueryable().Where(ProductQueries.GetById(_invalidId.GetValueOrDefault()));
        Assert.Empty(result);
    }

    [Fact]
    public void Should_Return_Products_When_Name_Is_Valid()
    {
        var result = _validProducts.AsQueryable().Where(ProductQueries.GetByName("S23"));
        Assert.Equal(1, result.Count());
    }

    [Fact]
    public void Should_Return_Empty_When_Name_Does_Not_Exists()
    {
        var result = _validProducts.AsQueryable().Where(ProductQueries.GetByName("Product"));
        Assert.Empty(result);
    }

    [Fact]
    public void Should_Return_Products_When_Tag_Is_Valid()
    {
        var result = _validProducts.AsQueryable().Where(ProductQueries.GetByTag("books"));
        Assert.Equal(2, result.Count());
    }

    [Fact]
    public void Should_Return_Empty_When_Tag_Does_Not_Exists()
    {
        var result = _validProducts.AsQueryable().Where(ProductQueries.GetByTag("tag"));
        Assert.Empty(result);
    }
}
