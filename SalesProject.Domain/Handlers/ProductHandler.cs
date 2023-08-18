using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.Contracts;
using SalesProject.Domain.Commands.ProductCommands;
using SalesProject.Domain.Handlers.Contracts;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Handlers;

public class ProductHandler : IHandler<CreateProductCommand>, IHandler<UpdateProductCommand>, IHandler<DeleteProductCommand>
{
    private readonly IProductRepository _repository;

    public ProductHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public ICommandResult Handle(CreateProductCommand command)
    {
        var product = new Product(command.Name, command.Description, command.Price, command.Tag);
        _repository.Create(product);

        return new GenericCommandResult(true, "Produto criado com sucesso!", product);
    }

    public ICommandResult Handle(UpdateProductCommand command)
    {
        var product = _repository.GetById(command.Id);
        product.Name = command.Name;
        product.Description = command.Description;
        product.Price = command.Price;
        product.Tag = command.Tag;
        _repository.Update(product);

        return new GenericCommandResult(true, "Produto atualizado com sucesso!", product);
    }

    public ICommandResult Handle(DeleteProductCommand command)
    {
        var product = _repository.GetById(command.Id);
        _repository.Delete(product);

        return new GenericCommandResult(true, "Produto removido com sucesso!", command.Id);
    }
}
