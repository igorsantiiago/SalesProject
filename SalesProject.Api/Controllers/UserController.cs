using Microsoft.AspNetCore.Mvc;
using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.UserCommands;
using SalesProject.Domain.Handlers;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Api.Controllers;

[ApiController]
[Route("v1/client")]
public class UserController : ControllerBase
{
    [HttpPost]
    [Route("create")]
    public GenericCommandResult Create([FromBody] CreateUserCommand command, [FromServices] UserHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut]
    [Route("update")]
    public GenericCommandResult Update([FromBody] UpdateUserCommand command, [FromServices] UserHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpDelete]
    [Route("delete")]
    public GenericCommandResult Delete([FromBody] DeleteUserCommand command, [FromServices] UserHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpGet]
    [Route("search/all")]
    public IEnumerable<User> GetAll([FromServices] IUserRepository repository)
    {
        return repository.GetAll();
    }

    [HttpGet]
    [Route("search/emails/{email}")]
    public IEnumerable<User> GetByEmail([FromServices] IUserRepository repository, [FromRoute] string email)
    {
        return repository.GetByEmail(email);
    }

    [HttpGet]
    [Route("search/{id}")]
    public User GetById([FromServices] IUserRepository repository, [FromRoute] Guid id)
    {
        return repository.GetById(id);
    }

    [HttpGet]
    [Route("search/names/{name}")]
    public IEnumerable<User> GetByName([FromServices] IUserRepository repository, [FromRoute] string name)
    {
        return repository.GetByName(name);
    }
}
