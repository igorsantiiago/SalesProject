using Microsoft.AspNetCore.Mvc;
using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.OrderCommands;
using SalesProject.Domain.Handlers;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Api.Controllers;

[ApiController]
[Route("v1/order")]
public class OrderController : ControllerBase
{
    [HttpPost]
    [Route("create")]
    public GenericCommandResult Create([FromBody] CreateOrderCommand command, [FromServices] OrderHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut]
    [Route("update")]
    public GenericCommandResult Update([FromBody] UpdateOrderCommand command, [FromServices] OrderHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpDelete]
    [Route("delete")]
    public GenericCommandResult Delete([FromBody] DeleteOrderCommand command, [FromServices] OrderHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut]
    [Route("product/add")]
    public GenericCommandResult AddProduct([FromBody] AddProductOrderCommand command, [FromServices] OrderHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut]
    [Route("product/remove")]
    public GenericCommandResult RemoveProducts([FromBody] RemoveProductOrderCommand command, [FromServices] OrderHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }


    [HttpGet]
    [Route("search/all")]
    public IEnumerable<Order> GetAll([FromServices] IOrderRepository repository)
    {
        return repository.GetAll();
    }

    [HttpGet]
    [Route("search/{id}")]
    public Order GetById([FromServices] IOrderRepository repository, [FromRoute] Guid id)
    {
        return repository.GetById(id);
    }
}
