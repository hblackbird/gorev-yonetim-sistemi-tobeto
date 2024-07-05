using Application.Features.Gorevs.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using MediatR;
using Domain.Enums;

namespace Application.Features.Gorevs.Commands.Create;

public class CreateGorevCommand : IRequest<CreatedGorevResponse>, ICacheRemoverRequest, ILoggableRequest
{
    public string Title { get; set; }
    public GorevDurumu Status { get; set; }
    public string Description { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetGorevs"];

    public class CreateGorevCommandHandler : IRequestHandler<CreateGorevCommand, CreatedGorevResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGorevRepository _gorevRepository;
        private readonly GorevBusinessRules _gorevBusinessRules;

        public CreateGorevCommandHandler(IMapper mapper, IGorevRepository gorevRepository,
                                         GorevBusinessRules gorevBusinessRules)
        {
            _mapper = mapper;
            _gorevRepository = gorevRepository;
            _gorevBusinessRules = gorevBusinessRules;
        }

        public async Task<CreatedGorevResponse> Handle(CreateGorevCommand request, CancellationToken cancellationToken)
        {
            Gorev gorev = _mapper.Map<Gorev>(request);

            await _gorevRepository.AddAsync(gorev);

            CreatedGorevResponse response = _mapper.Map<CreatedGorevResponse>(gorev);
            return response;
        }
    }
}