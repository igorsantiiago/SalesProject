using Microsoft.AspNetCore.Mvc;
using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.RoleCommands;
using SalesProject.Domain.Handlers;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Api.Controllers;

[ApiController]
[Route("v1/role")]
public class RoleController : ControllerBase
{
    [HttpPost]
    [Route("create")]
    public GenericCommandResult Create([FromBody] CreateRoleCommand command, [FromServices] RoleHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut]
    [Route("update")]
    public GenericCommandResult Update([FromBody] UpdateRoleCommand command, [FromServices] RoleHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpDelete]
    [Route("delete")]
    public GenericCommandResult Delete([FromBody] DeleteRoleCommand command, [FromServices] RoleHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpGet]
    [Route("search/all")]
    public IEnumerable<Role> GetAll([FromServices] IRoleRepository repository)
    {
        return repository.GetAll();
    }

    [HttpGet]
    [Route("search/{id}")]
    public Role GetById([FromServices] IRoleRepository repository, [FromRoute] Guid id)
    {
        return repository.GetById(id);
    }

    [HttpGet]
    [Route("search/name/{name}")]
    public IEnumerable<Role> GetByName([FromServices] IRoleRepository repository, [FromRoute] string name)
    {
        return repository.GetByName(name);
    }

    [HttpGet]
    [Route("search/slug/{slug}")]
    public IEnumerable<Role> GetBySlug([FromServices] IRoleRepository repository, [FromRoute] string slug)
    {
        return repository.GetBySlug(slug);
    }
}