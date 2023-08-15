using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.ClientCommands;
using SalesProject.Domain.Commands.Contracts;
using SalesProject.Domain.Handlers.Contracts;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Handlers;

public class ClientHandler : IHandler<CreateClientCommand>, IHandler<UpdateClientCommand>, IHandler<DeleteClientCommand>
{
    private readonly IClientRepository _repository;

    public ClientHandler(IClientRepository repository)
    {
        _repository = repository;
    }

    public ICommandResult Handle(CreateClientCommand command)
    {
        var client = new Client(command.Name, command.Email, command.PhoneNumber);
        _repository.Create(client);

        return new GenericCommandResult(true, "Cliente criado com sucesso!", client);
    }

    public ICommandResult Handle(UpdateClientCommand command)
    {
        var client = _repository.GetById(command.Id);
        client.Name = command.Name;
        client.Email = command.Email;
        client.PhoneNumber = command.PhoneNumber;
        _repository.Update(client);

        return new GenericCommandResult(true, "Cliente atualizado com sucesso!", client);
    }

    public ICommandResult Handle(DeleteClientCommand command)
    {
        var client = _repository.GetById(command.Id);
        _repository.Delete(client);

        return new GenericCommandResult(true, "Cliente removido com sucesso!", command.Id);
    }
}
