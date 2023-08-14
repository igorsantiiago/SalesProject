using Microsoft.AspNetCore.Mvc;
using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.AdminCommands;
using SalesProject.Domain.Handlers;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Api.Controllers;

[ApiController]
[Route("v1/admin")]
public class AdminController : ControllerBase
{
    [HttpPost]
    [Route("create")]
    public GenericCommandResult Create([FromBody] CreateAdminCommand command, [FromServices] AdminHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpPut]
    [Route("update")]
    public GenericCommandResult Update([FromBody] UpdateAdminCommand command, [FromServices] AdminHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpDelete]
    [Route("delete")]
    public GenericCommandResult Delete([FromBody] DeleteAdminCommand command, [FromServices] AdminHandler handler)
    {
        return (GenericCommandResult)handler.Handle(command);
    }

    [HttpGet]
    [Route("search/all")]
    public IEnumerable<Admin> GetAll([FromServices] IAdminRepository repository)
    {
        return repository.GetAll();
    }

    [HttpGet]
    [Route("search/emails/{email}")]
    public IEnumerable<Admin> GetByEmail([FromServices] IAdminRepository repository, [FromRoute] string email)
    {
        return repository.GetByEmail(email);
    }

    [HttpGet]
    [Route("search/{id}")]
    public Admin GetById([FromServices] IAdminRepository repository, [FromRoute] Guid id)
    {
        return repository.GetById(id);
    }
    
    [HttpGet]
    [Route("search/names/{name}")]
    public IEnumerable<Admin> GetByName([FromServices] IAdminRepository repository, [FromRoute] string name)
    {
        return repository.GetByName(name);
    }

    [HttpGet]
    [Route("search/roles/{role}")]
    public IEnumerable<Admin> GetByRole([FromServices] IAdminRepository repository, [FromRoute] string role)
    {
        return repository.GetByRole(role);
    }
}
