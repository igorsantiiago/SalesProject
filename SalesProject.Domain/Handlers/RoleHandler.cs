using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.Contracts;
using SalesProject.Domain.Commands.RoleCommands;
using SalesProject.Domain.Handlers.Contracts;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Handlers;

public class RoleHandler : IHandler<CreateRoleCommand>, IHandler<UpdateRoleCommand>, IHandler<DeleteRoleCommand>
{
    private readonly IRoleRepository _repository;

    public RoleHandler(IRoleRepository repository)
    {
        _repository = repository;
    }

    public ICommandResult Handle(CreateRoleCommand command)
    {
        var role = new Role(command.Name, command.Slug);
        _repository.Create(role);

        return new GenericCommandResult(true, "Função criada com sucesso!", role);
    }

    public ICommandResult Handle(UpdateRoleCommand command)
    {
        var role = _repository.GetById(command.Id);
        role.Name = command.Name;
        role.Slug = command.Slug;
        _repository.Update(role);

        return new GenericCommandResult(true, "Função atualizada com sucesso!", role);
    }

    public ICommandResult Handle(DeleteRoleCommand command)
    {
        var role = _repository.GetById(command.Id);
        _repository.Delete(role);

        return new GenericCommandResult(true, "Função removida com sucesso!", command.Id);
    }
}
