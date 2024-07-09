using Domain.Enums;
using FluentValidation;

namespace Application.Features.Gorevs.Commands.Create;

public class CreateGorevCommandValidator : AbstractValidator<CreateGorevCommand>
{
    public CreateGorevCommandValidator()
    {
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.Status).IsInEnum();
        RuleFor(c => c.Description).NotEmpty();
    }
    private bool BeAValidStatus(GorevDurumu status)
    {
        return Enum.IsDefined(typeof(GorevDurumu), status);
    }
}