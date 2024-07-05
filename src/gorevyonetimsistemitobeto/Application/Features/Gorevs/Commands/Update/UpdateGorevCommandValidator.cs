using FluentValidation;

namespace Application.Features.Gorevs.Commands.Update;

public class UpdateGorevCommandValidator : AbstractValidator<UpdateGorevCommand>
{
    public UpdateGorevCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
    }
}