using Microsoft.AspNetCore.Mvc;
using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.ClientCommands;
using SalesProject.Domain.Handlers;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Api.Controllers;

[ApiController]
[Route("v1/client")]
public class ClientController : ControllerBase
{
    [HttpPost]
    [Route("create")]
    public GenericCommandResult Create([FromBody] CreateClientCommand command, [FromServices] ClientHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut]
    [Route("update")]
    public GenericCommandResult Update([FromBody] UpdateClientCommand command, [FromServices] ClientHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpDelete]
    [Route("delete")]
    public GenericCommandResult Delete([FromBody] DeleteClientCommand command, [FromServices] ClientHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpGet]
    [Route("search/all")]
    public IEnumerable<Client> GetAll([FromServices] IClientRepository repository)
    {
        return repository.GetAll();
    }

    [HttpGet]
    [Route("search/emails/{email}")]
    public IEnumerable<Client> GetByEmail([FromServices] IClientRepository repository, [FromRoute] string email)
    {
        return repository.GetByEmail(email);
    }

    [HttpGet]
    [Route("search/{id}")]
    public Client GetById([FromServices] IClientRepository repository, [FromRoute] Guid id)
    {
        return repository.GetById(id);
    }

    [HttpGet]
    [Route("search/names/{name}")]
    public IEnumerable<Client> GetByName([FromServices] IClientRepository repository, [FromRoute] string name)
    {
        return repository.GetByName(name);
    }
}
