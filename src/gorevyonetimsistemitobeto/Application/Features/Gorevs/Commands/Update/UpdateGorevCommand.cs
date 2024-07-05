using Application.Features.Gorevs.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using MediatR;
using Domain.Enums;

namespace Application.Features.Gorevs.Commands.Update;

public class UpdateGorevCommand : IRequest<UpdatedGorevResponse>, ICacheRemoverRequest, ILoggableRequest
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public GorevDurumu Status { get; set; }
    public string Description { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetGorevs"];

    public class UpdateGorevCommandHandler : IRequestHandler<UpdateGorevCommand, UpdatedGorevResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGorevRepository _gorevRepository;
        private readonly GorevBusinessRules _gorevBusinessRules;

        public UpdateGorevCommandHandler(IMapper mapper, IGorevRepository gorevRepository,
                                         GorevBusinessRules gorevBusinessRules)
        {
            _mapper = mapper;
            _gorevRepository = gorevRepository;
            _gorevBusinessRules = gorevBusinessRules;
        }

        public async Task<UpdatedGorevResponse> Handle(UpdateGorevCommand request, CancellationToken cancellationToken)
        {
            Gorev? gorev = await _gorevRepository.GetAsync(predicate: g => g.Id == request.Id, cancellationToken: cancellationToken);
            await _gorevBusinessRules.GorevShouldExistWhenSelected(gorev);
            gorev = _mapper.Map(request, gorev);

            await _gorevRepository.UpdateAsync(gorev!);

            UpdatedGorevResponse response = _mapper.Map<UpdatedGorevResponse>(gorev);
            return response;
        }
    }
}