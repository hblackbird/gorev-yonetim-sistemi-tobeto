using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IGorevRepository : IAsyncRepository<Gorev, Guid>, IRepository<Gorev, Guid>
{
    Task HardDeleteAsync(Gorev gorev);
}