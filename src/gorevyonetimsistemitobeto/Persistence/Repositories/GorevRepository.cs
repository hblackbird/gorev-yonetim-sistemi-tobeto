using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class GorevRepository : EfRepositoryBase<Gorev, Guid, BaseDbContext>, IGorevRepository
{
    public GorevRepository(BaseDbContext context) : base(context)
    {
    }
}