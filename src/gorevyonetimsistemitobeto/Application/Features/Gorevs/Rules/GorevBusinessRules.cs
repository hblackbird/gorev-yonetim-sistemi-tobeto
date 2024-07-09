using Application.Features.Gorevs.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;
using Application.Features.Users.Rules;
using Application.Features.Users.Constants;

namespace Application.Features.Gorevs.Rules;

public class GorevBusinessRules : BaseBusinessRules
{
    private readonly IGorevRepository _gorevRepository;
    private readonly ILocalizationService _localizationService;
    private readonly IUserRepository _userRepository;

    public GorevBusinessRules(IGorevRepository gorevRepository, ILocalizationService localizationService, IUserRepository userRepository)
    {
        _gorevRepository = gorevRepository;
        _localizationService = localizationService;
        _userRepository = userRepository;
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
    public async Task UserShouldExist(Guid userId)
    {
        var user = await _userRepository.GetAsync(
            predicate: c => c.Id == userId,
            enableTracking: false
        );

        if (user == null)
        {
            await throwBusinessException(UsersMessages.UserDontExists);
        }
    }
}