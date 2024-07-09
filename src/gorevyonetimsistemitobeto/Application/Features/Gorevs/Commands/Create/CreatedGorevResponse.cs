using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.Gorevs.Commands.Create;

public class CreatedGorevResponse : IResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Guid UserId { get; set; }
    public GorevDurumu Status { get; set; }
    public string Description { get; set; }
}