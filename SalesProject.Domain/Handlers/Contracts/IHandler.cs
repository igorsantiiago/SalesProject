using SalesProject.Domain.Commands.Contracts;

namespace SalesProject.Domain.Handlers.Contracts;

public interface IHandler<T> where T : ICommand
{
    ICommandResult Handle(T command);
}
