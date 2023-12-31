﻿using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Commands.OrderCommands;

public class RemoveProductOrderCommand : ICommand
{
    protected RemoveProductOrderCommand() { }
    public RemoveProductOrderCommand(Guid orderId, Guid productId)
    {
        OrderId = orderId;
        ProductId = productId;
    }

    [Required(ErrorMessage = "Insira o Id do pedido!")]
    public Guid OrderId { get; set; }

    [Required(ErrorMessage = "Insira o Id do produto!")]
    public Guid ProductId { get; set; }
}
