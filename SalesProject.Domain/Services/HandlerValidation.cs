using SalesProject.Domain.Commands;
using SalesProject.Domain.Commands.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SalesProject.Domain.Services;

public class HandlerValidation
{
    public GenericCommandResult Validate(ICommand command)
    {
        var validationContext = new ValidationContext(command);
        var validationResult = new List<ValidationResult>();

        if (!Validator.TryValidateObject(command, validationContext, validationResult, true))
        {
            var errorMessages = validationResult.Select(x => x.ErrorMessage);
            var errorMessage = string.Join(" | ", errorMessages);

            return new GenericCommandResult(false, errorMessage, null!);
        }

        return new GenericCommandResult(true, "Validation Succeeded", null!);
    }
}
