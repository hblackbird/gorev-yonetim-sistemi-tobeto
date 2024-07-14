using NArchitecture.Core.Application.Dtos;
using Domain.Enums;

namespace Application.Features.Gorevs.Queries.GetList;

public class GetListGorevListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Guid UserId { get; set; }
    public GorevDurumu Status { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
}