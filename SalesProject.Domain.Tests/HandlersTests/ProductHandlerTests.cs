using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.ProductCommands;
using SalesProject.Domain.Handlers;
using SalesProject.Domain.Tests.Repositories;

namespace SalesProject.Domain.Tests.HandlersTests;

public class ProductHandlerTests
{
    private readonly CreateProductCommand _validCreateProductCommand = new("Clean Code", "Livro Clean Code", 89, "books");
    private readonly CreateProductCommand _invalidCreateProductCommand = new("", "", 99, "");

    private readonly UpdateProductCommand _validUpdateProductCommand = new(Guid.NewGuid(), "Clean Code", "Livro Clean Code", 89, "books");
    private readonly UpdateProductCommand _invalidUpdateProductCommand = new(Guid.NewGuid(), "", "", 89, "");

    private readonly DeleteProductCommand _validDeleteProductCommand = new(Guid.NewGuid());

    private readonly ProductHandler _handler = new(new FakeProductRepository());

    public ProductHandlerTests() { }

    [Fact]
    public void Should_Create_Product_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validCreateProductCommand);
        Assert.True(result.Success);
    }

    [Fact]
    public void Should_Fail_When_Create_Product_Command_Is_Invalid()
    {
        var result = (GenericCommandResult)_handler.Handle(_invalidCreateProductCommand);
        Assert.False(result.Success);
    }

    [Fact]
    public void Should_Update_Product_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validUpdateProductCommand);
        Assert.True(result.Success);
    }

    [Fact]
    public void Should_Fail_When_Update_Product_Command_Is_Invalid()
    {
        var result = (GenericCommandResult)_handler.Handle(_invalidUpdateProductCommand);
        Assert.False(result.Success);
    }

    [Fact]
    public void Should_Delete_Product_When_Command_Is_Valid()
    {
        var result = (GenericCommandResult)_handler.Handle(_validDeleteProductCommand);
        Assert.True(result.Success);
    }
}
