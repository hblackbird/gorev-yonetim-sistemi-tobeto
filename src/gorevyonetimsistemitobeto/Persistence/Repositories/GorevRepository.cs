using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;
using System.Linq.Expressions;

namespace Persistence.Repositories;

public class GorevRepository : EfRepositoryBase<Gorev, Guid, BaseDbContext>, IGorevRepository
{
    private readonly BaseDbContext _context;
    public GorevRepository(BaseDbContext context) : base(context)
    {
        _context = context;
    }
    public async Task HardDeleteAsync(Gorev gorev)
    {
        _context.Set<Gorev>().Remove(gorev);
        await _context.SaveChangesAsync();
    }
}