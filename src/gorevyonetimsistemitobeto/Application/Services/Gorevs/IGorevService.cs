using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Gorevs;

public interface IGorevService
{
    Task<Gorev?> GetAsync(
        Expression<Func<Gorev, bool>> predicate,
        Func<IQueryable<Gorev>, IIncludableQueryable<Gorev, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<Gorev>?> GetListAsync(
        Expression<Func<Gorev, bool>>? predicate = null,
        Func<IQueryable<Gorev>, IOrderedQueryable<Gorev>>? orderBy = null,
        Func<IQueryable<Gorev>, IIncludableQueryable<Gorev, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<Gorev> AddAsync(Gorev gorev);
    Task<Gorev> UpdateAsync(Gorev gorev);
    Task<Gorev> DeleteAsync(Gorev gorev, bool permanent = false);
}
