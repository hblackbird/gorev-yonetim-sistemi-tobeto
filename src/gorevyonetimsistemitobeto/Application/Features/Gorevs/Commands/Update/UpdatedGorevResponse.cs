using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.Gorevs.Commands.Update;

public class UpdatedGorevResponse : IResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public GorevDurumu Status { get; set; }
    public string Description { get; set; }
}