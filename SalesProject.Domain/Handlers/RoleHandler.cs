using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.Contracts;
using SalesProject.Domain.Commands.RoleCommands;
using SalesProject.Domain.Handlers.Contracts;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;
using SalesProject.Domain.Services;

namespace SalesProject.Domain.Handlers;

public class RoleHandler : IHandler<CreateRoleCommand>, IHandler<UpdateRoleCommand>, IHandler<DeleteRoleCommand>
{
    private readonly IRoleRepository _repository;
    private HandlerValidation _handlerValidation = new HandlerValidation();

    public RoleHandler(IRoleRepository repository)
    {
        _repository = repository;
    }

    public ICommandResult Handle(CreateRoleCommand command)
    {
        var validationResponse = _handlerValidation.Validate(command);
        if (!validationResponse.Success)
            return validationResponse;

        var role = new Role(command.Name, command.Slug);
        _repository.Create(role);

        return new GenericCommandResult(true, "Função criada com sucesso!", role);
    }

    public ICommandResult Handle(UpdateRoleCommand command)
    {
        var validationResponse = _handlerValidation.Validate(command);
        if (!validationResponse.Success)
            return validationResponse;

        var role = _repository.GetById(command.Id);
        role.Name = command.Name;
        role.Slug = command.Slug;
        _repository.Update(role);

        return new GenericCommandResult(true, "Função atualizada com sucesso!", role);
    }

    public ICommandResult Handle(DeleteRoleCommand command)
    {
        var validationResponse = _handlerValidation.Validate(command);
        if (!validationResponse.Success)
            return validationResponse;

        var role = _repository.GetById(command.Id);
        _repository.Delete(role);

        return new GenericCommandResult(true, "Função removida com sucesso!", command.Id);
    }
}
