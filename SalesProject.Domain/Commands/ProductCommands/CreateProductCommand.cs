using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Commands.ProductCommands;

public class CreateProductCommand : ICommand
{
    protected CreateProductCommand() { }
    public CreateProductCommand(string name, string description, decimal price, string tag)
    {
        Name = name;
        Description = description;
        Price = price;
        Tag = tag;
    }

    [Required(ErrorMessage = "Insira um Nome ao produto!")]
    [StringLength(120, MinimumLength = 3, ErrorMessage = "O nome do produto precisa conter no mínimo 3 caracteres e no máximo 120 caracteres.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Insira a descrição do produto!")]
    [StringLength(255, MinimumLength = 6, ErrorMessage = "A descrição do produto precisa conter no mínimo 6 caracteres e no máximo 255 caracteres.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Insira o valor do produto!")]
    [DataType(DataType.Currency, ErrorMessage = "Insira um valor relativo a moeda.")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Insira a tag do produto!")]
    [StringLength(40, MinimumLength = 3, ErrorMessage = "A tag do produto precisa conter no mínimo 3 caracteres e no máximo 40 caracteres.")]
    public string Tag { get; set; }
}
