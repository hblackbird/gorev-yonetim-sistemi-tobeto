using FluentValidation;

namespace Application.Features.Gorevs.Commands.Delete;

public class DeleteGorevCommandValidator : AbstractValidator<DeleteGorevCommand>
{
    public DeleteGorevCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}