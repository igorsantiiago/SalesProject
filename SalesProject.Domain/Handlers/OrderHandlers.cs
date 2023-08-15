using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.Contracts;
using SalesProject.Domain.Commands.OrderCommands;
using SalesProject.Domain.Handlers.Contracts;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Handlers;

public class OrderHandlers : IHandler<CreateOrderCommand>, IHandler<UpdateOrderCommand>, IHandler<DeleteOrderCommand>,
    IHandler<AddProductOrderCommand>, IHandler<RemoveProductOrderCommand>
{
    private readonly IOrderRepository _repository;
    private readonly IProductRepository _productRepository;

    public OrderHandlers(IOrderRepository repository, IProductRepository productRepository)
    {
        _repository = repository;
        _productRepository = productRepository;
    }

    public ICommandResult Handle(CreateOrderCommand command)
    {
        var order = new Order(command.ClientId);
        order.TotalCost();
        _repository.Create(order);

        return new GenericCommandResult(true, "Pedido criado com sucesso!", order);
    }

    public ICommandResult Handle(UpdateOrderCommand command)
    {
        var order = _repository.GetById(command.Id);
        order.ClientId = command.ClientId;
        _repository.Update(order);

        return new GenericCommandResult(true, "Pedido atualizado com sucesso!", order);
    }

    public ICommandResult Handle(DeleteOrderCommand command)
    {
        var order = _repository.GetById(command.Id);
        _repository.Delete(order);

        return new GenericCommandResult(true, "Pedido removido com sucesso!", command.Id);
    }

    public ICommandResult Handle(AddProductOrderCommand command)
    {
        var order = _repository.GetById(command.Id);
        var product = _productRepository.GetById(command.ProductId);

        order.AddProduct(product);
        order.TotalCost();

        return new GenericCommandResult(true, "Produto adicionado ao pedido com sucesso!", command.Id);
    }

    public ICommandResult Handle(RemoveProductOrderCommand command)
    {
        var order = _repository.GetById(command.Id);
        if (order == null) return new GenericCommandResult(false, "Pedido não encontrado", command.Id);

        var product = _productRepository.GetById(command.ProductId);
        if (product == null) return new GenericCommandResult(false, "Produto não encontrado", command.ProductId);

        order.RemoveProduct(product);
        return new GenericCommandResult(true, "Produto removido do pedido com sucesso!", command.Id);
    }
}