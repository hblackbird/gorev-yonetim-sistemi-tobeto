using NArchitecture.Core.Application.Responses;

namespace Application.Features.Gorevs.Commands.Delete;

public class DeletedGorevResponse : IResponse
{
    public Guid Id { get; set; }
}