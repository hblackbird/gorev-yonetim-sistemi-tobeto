using Application.Features.Gorevs.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.Gorevs.Rules;

public class GorevBusinessRules : BaseBusinessRules
{
    private readonly IGorevRepository _gorevRepository;
    private readonly ILocalizationService _localizationService;

    public GorevBusinessRules(IGorevRepository gorevRepository, ILocalizationService localizationService)
    {
        _gorevRepository = gorevRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, GorevsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task GorevShouldExistWhenSelected(Gorev? gorev)
    {
        if (gorev == null)
            await throwBusinessException(GorevsBusinessMessages.GorevNotExists);
    }

    public async Task GorevIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Gorev? gorev = await _gorevRepository.GetAsync(
            predicate: g => g.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await GorevShouldExistWhenSelected(gorev);
    }
}