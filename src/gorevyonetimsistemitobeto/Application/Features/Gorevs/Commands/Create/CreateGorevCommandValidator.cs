using FluentValidation;

namespace Application.Features.Gorevs.Commands.Create;

public class CreateGorevCommandValidator : AbstractValidator<CreateGorevCommand>
{
    public CreateGorevCommandValidator()
    {
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
    }
}