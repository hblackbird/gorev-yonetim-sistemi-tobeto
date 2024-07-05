using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.Gorevs.Queries.GetById;

public class GetByIdGorevResponse : IResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public GorevDurumu Status { get; set; }
    public string Description { get; set; }
}