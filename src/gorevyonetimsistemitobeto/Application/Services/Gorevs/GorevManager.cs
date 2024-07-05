using Application.Features.Gorevs.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Gorevs;

public class GorevManager : IGorevService
{
    private readonly IGorevRepository _gorevRepository;
    private readonly GorevBusinessRules _gorevBusinessRules;

    public GorevManager(IGorevRepository gorevRepository, GorevBusinessRules gorevBusinessRules)
    {
        _gorevRepository = gorevRepository;
        _gorevBusinessRules = gorevBusinessRules;
    }

    public async Task<Gorev?> GetAsync(
        Expression<Func<Gorev, bool>> predicate,
        Func<IQueryable<Gorev>, IIncludableQueryable<Gorev, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        Gorev? gorev = await _gorevRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return gorev;
    }

    public async Task<IPaginate<Gorev>?> GetListAsync(
        Expression<Func<Gorev, bool>>? predicate = null,
        Func<IQueryable<Gorev>, IOrderedQueryable<Gorev>>? orderBy = null,
        Func<IQueryable<Gorev>, IIncludableQueryable<Gorev, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<Gorev> gorevList = await _gorevRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return gorevList;
    }

    public async Task<Gorev> AddAsync(Gorev gorev)
    {
        Gorev addedGorev = await _gorevRepository.AddAsync(gorev);

        return addedGorev;
    }

    public async Task<Gorev> UpdateAsync(Gorev gorev)
    {
        Gorev updatedGorev = await _gorevRepository.UpdateAsync(gorev);

        return updatedGorev;
    }

    public async Task<Gorev> DeleteAsync(Gorev gorev, bool permanent = false)
    {
        Gorev deletedGorev = await _gorevRepository.DeleteAsync(gorev);

        return deletedGorev;
    }
}
