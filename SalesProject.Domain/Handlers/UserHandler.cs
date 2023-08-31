using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.UserCommands;
using SalesProject.Domain.Commands.Contracts;
using SalesProject.Domain.Handlers.Contracts;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;
using SalesProject.Domain.Services;

namespace SalesProject.Domain.Handlers;

public class UserHandler : IHandler<CreateUserCommand>, IHandler<UpdateUserCommand>, IHandler<DeleteUserCommand>
{
    private readonly IUserRepository _repository;
    private HandlerValidation _handlerValidation = new HandlerValidation();

    public UserHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public ICommandResult Handle(CreateUserCommand command)
    {
        var validationResponse = _handlerValidation.Validate(command);
        if (!validationResponse.Success)
            return validationResponse;

        var user = new User(command.Name, command.Email, command.PhoneNumber, command.PasswordHash, command.RoleId);
        _repository.Create(user);

        return new GenericCommandResult(true, "Usuário criado com sucesso!", user);
    }

    public ICommandResult Handle(UpdateUserCommand command)
    {
        var validationResponse = _handlerValidation.Validate(command);
        if (!validationResponse.Success)
            return validationResponse;

        var user = _repository.GetById(command.Id);
        user.Name = command.Name;
        user.Email = command.Email;
        user.PhoneNumber = command.PhoneNumber;
        user.RoleId = command.RoleId;
        _repository.Update(user);

        return new GenericCommandResult(true, "Usuário atualizado com sucesso!", user);
    }

    public ICommandResult Handle(DeleteUserCommand command)
    {
        var validationResponse = _handlerValidation.Validate(command);
        if (!validationResponse.Success)
            return validationResponse;

        var user = _repository.GetById(command.Id);
        _repository.Delete(user);

        return new GenericCommandResult(true, "Usuário removido com sucesso!", command.Id);
    }
}
