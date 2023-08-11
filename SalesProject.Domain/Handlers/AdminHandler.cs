using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.AdminCommands;
using SalesProject.Domain.Commands.Contracts;
using SalesProject.Domain.Handlers.Contracts;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Handlers;

public class AdminHandler : IHandler<CreateAdminCommand>, IHandler<UpdateAdminCommand>, IHandler<DeleteAdminCommand>
{
    private readonly IAdminRepository _repository;

    public AdminHandler(IAdminRepository repository)
    {
        _repository = repository;
    }

    public ICommandResult Handle(CreateAdminCommand command)
    {
        var admin = new Admin(command.Name, command.Email, command.PasswordHash);
        _repository.Create(admin);

        return new GenericCommandResult(true, "Admin cadastrado com sucesso!", admin);
    }

    public ICommandResult Handle(UpdateAdminCommand command)
    {
        var admin = _repository.GetById(command.Id);
        admin.Name = command.Name;
        admin.Email = command.Email;
        admin.PasswordHash = command.PasswordHash;
        _repository.Update(admin);

        return new GenericCommandResult(true, "Admin atualizado com sucesso!", admin);
    }

    public ICommandResult Handle(DeleteAdminCommand command)
    {
        var admin = _repository.GetById(command.Id);
        _repository.Delete(admin);

        return new GenericCommandResult(true, "Admin removido com sucesso!", command.Id);
    }
}
