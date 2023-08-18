using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.Contracts;
using SalesProject.Domain.Commands.OrderCommands;
using SalesProject.Domain.Handlers.Contracts;
using SalesProject.Domain.Models;
using SalesProject.Domain.Repositories;

namespace SalesProject.Domain.Handlers;

public class OrderHandler : IHandler<CreateOrderCommand>, IHandler<UpdateOrderCommand>, IHandler<DeleteOrderCommand>,
    IHandler<AddProductOrderCommand>, IHandler<RemoveProductOrderCommand>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IProductRepository _productRepository;
    private readonly IOrderProductRepository _orderProductRepository;

    public OrderHandler(IOrderRepository orderRepository, IProductRepository productRepository, IOrderProductRepository orderProductRepository)
    {
        _orderRepository = orderRepository;
        _productRepository = productRepository;
        _orderProductRepository = orderProductRepository;
    }

    public ICommandResult Handle(CreateOrderCommand command)
    {
        var order = new Order(command.UserId);
        order.CalculateTotalPriceAfterAddingProduct();
        _orderRepository.Create(order);

        return new GenericCommandResult(true, "Pedido criado com sucesso!", order);
    }

    public ICommandResult Handle(UpdateOrderCommand command)
    {
        var order = _orderRepository.GetById(command.Id);
        order.UserId = command.UserId;
        _orderRepository.Update(order);

        return new GenericCommandResult(true, "Pedido atualizado com sucesso!", order);
    }

    public ICommandResult Handle(DeleteOrderCommand command)
    {
        var order = _orderRepository.GetById(command.Id);
        _orderRepository.Delete(order);

        return new GenericCommandResult(true, "Pedido removido com sucesso!", command.Id);
    }

    public ICommandResult Handle(AddProductOrderCommand command)
    {
        var order = _orderRepository.GetById(command.OrderId);
        if(order == null)
            return new GenericCommandResult(false, "Falha na Order!", command.OrderId);

        var product = _productRepository.GetById(command.ProductId);
        if(product == null)
            return new GenericCommandResult(false, "Falha no Product!", command.ProductId);

        order.Products.Add(product);
        order.CalculateTotalPriceAfterAddingProduct();
        _orderRepository.Update(order);

        return new GenericCommandResult(true, "Produto adicionado com sucesso!", command.OrderId);
    }

    public ICommandResult Handle(RemoveProductOrderCommand command)
    {
        var order = _orderRepository.GetById(command.OrderId);
        if (order == null)
            return new GenericCommandResult(false, "Falha na Order!", command.OrderId);

        var product = _productRepository.GetById(command.ProductId);
        if (product == null)
            return new GenericCommandResult(false, "Falha no Product!", command.ProductId);

        var orderProduct = _orderProductRepository.GetOrderProduct(order, product);
        order.OrderProducts.Remove(orderProduct);
        order.CalculateTotalPriceAfterRemovingProduct();
        _orderRepository.Update(order);

        return new GenericCommandResult(true, "Produto removido com sucesso!", command.OrderId);
    }
}