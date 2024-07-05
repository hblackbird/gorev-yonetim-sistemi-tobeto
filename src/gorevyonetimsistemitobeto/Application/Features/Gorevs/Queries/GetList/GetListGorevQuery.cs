using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;

namespace Application.Features.Gorevs.Queries.GetList;

public class GetListGorevQuery : IRequest<GetListResponse<GetListGorevListItemDto>>, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListGorevs({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetGorevs";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListGorevQueryHandler : IRequestHandler<GetListGorevQuery, GetListResponse<GetListGorevListItemDto>>
    {
        private readonly IGorevRepository _gorevRepository;
        private readonly IMapper _mapper;

        public GetListGorevQueryHandler(IGorevRepository gorevRepository, IMapper mapper)
        {
            _gorevRepository = gorevRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListGorevListItemDto>> Handle(GetListGorevQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Gorev> gorevs = await _gorevRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListGorevListItemDto> response = _mapper.Map<GetListResponse<GetListGorevListItemDto>>(gorevs);
            return response;
        }
    }
}