using Microsoft.AspNetCore.Mvc;
using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.ProductCommands;
using SalesProject.Domain.Handlers;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Api.Controllers;

[ApiController]
[Route("v1/product")]
public class ProductController : ControllerBase
{
    [HttpPost]
    [Route("create")]
    public GenericCommandResult Create([FromBody] CreateProductCommand command, [FromServices] ProductHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut]
    [Route("update")]
    public GenericCommandResult Update([FromBody] UpdateProductCommand command, [FromServices] ProductHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpDelete]
    [Route("delete")]
    public GenericCommandResult Delete([FromBody] DeleteProductCommand command, [FromServices] ProductHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpGet]
    [Route("search/all")]
    public IEnumerable<Product> GetAll([FromServices] IProductRepository repository)
    {
        return repository.GetAll();
    }

    [HttpGet]
    [Route("search/{id}")]
    public Product GetById([FromServices] IProductRepository repository, [FromRoute] Guid id)
    {
        return repository.GetById(id);
    }

    [HttpGet]
    [Route("search/names/{name}")]
    public IEnumerable<Product> GetByName([FromServices] IProductRepository repository, [FromRoute] string name)
    {
        return repository.GetByName(name);
    }

    [HttpGet]
    [Route("search/tags/{tag}")]
    public IEnumerable<Product> GetByTag([FromServices] IProductRepository repository, [FromRoute] string tag)
    {
        return repository.GetByTag(tag);
    }
}
