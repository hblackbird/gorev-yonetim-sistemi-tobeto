using Application.Features.Gorevs.Constants;
using Application.Features.Gorevs.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using MediatR;

namespace Application.Features.Gorevs.Commands.Delete;

public class DeleteGorevCommand : IRequest<DeletedGorevResponse>, ICacheRemoverRequest, ILoggableRequest
{
    public Guid Id { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetGorevs"];

    public class DeleteGorevCommandHandler : IRequestHandler<DeleteGorevCommand, DeletedGorevResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGorevRepository _gorevRepository;
        private readonly GorevBusinessRules _gorevBusinessRules;

        public DeleteGorevCommandHandler(IMapper mapper, IGorevRepository gorevRepository,
                                         GorevBusinessRules gorevBusinessRules)
        {
            _mapper = mapper;
            _gorevRepository = gorevRepository;
            _gorevBusinessRules = gorevBusinessRules;
        }

        public async Task<DeletedGorevResponse> Handle(DeleteGorevCommand request, CancellationToken cancellationToken)
        {
            Gorev? gorev = await _gorevRepository.GetAsync(predicate: g => g.Id == request.Id, cancellationToken: cancellationToken);
            await _gorevBusinessRules.GorevShouldExistWhenSelected(gorev);

            await _gorevRepository.DeleteAsync(gorev!);

            DeletedGorevResponse response = _mapper.Map<DeletedGorevResponse>(gorev);
            return response;
        }
    }
}