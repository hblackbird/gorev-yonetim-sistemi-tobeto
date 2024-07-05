using Application.Features.Gorevs.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Gorevs.Queries.GetById;

public class GetByIdGorevQuery : IRequest<GetByIdGorevResponse>
{
    public Guid Id { get; set; }

    public class GetByIdGorevQueryHandler : IRequestHandler<GetByIdGorevQuery, GetByIdGorevResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGorevRepository _gorevRepository;
        private readonly GorevBusinessRules _gorevBusinessRules;

        public GetByIdGorevQueryHandler(IMapper mapper, IGorevRepository gorevRepository, GorevBusinessRules gorevBusinessRules)
        {
            _mapper = mapper;
            _gorevRepository = gorevRepository;
            _gorevBusinessRules = gorevBusinessRules;
        }

        public async Task<GetByIdGorevResponse> Handle(GetByIdGorevQuery request, CancellationToken cancellationToken)
        {
            Gorev? gorev = await _gorevRepository.GetAsync(predicate: g => g.Id == request.Id, cancellationToken: cancellationToken);
            await _gorevBusinessRules.GorevShouldExistWhenSelected(gorev);

            GetByIdGorevResponse response = _mapper.Map<GetByIdGorevResponse>(gorev);
            return response;
        }
    }
}