using Application.Features.Gorevs.Commands.Create;
using Application.Features.Gorevs.Commands.Delete;
using Application.Features.Gorevs.Commands.Update;
using Application.Features.Gorevs.Queries.GetById;
using Application.Features.Gorevs.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Gorevs.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Gorev, CreateGorevCommand>().ReverseMap();
        CreateMap<Gorev, CreatedGorevResponse>().ReverseMap();
        CreateMap<Gorev, UpdateGorevCommand>().ReverseMap();
        CreateMap<Gorev, UpdatedGorevResponse>().ReverseMap();
        CreateMap<Gorev, DeleteGorevCommand>().ReverseMap();
        CreateMap<Gorev, DeletedGorevResponse>().ReverseMap();
        CreateMap<Gorev, GetByIdGorevResponse>().ReverseMap();
        CreateMap<Gorev, GetListGorevListItemDto>().ReverseMap();
        CreateMap<IPaginate<Gorev>, GetListResponse<GetListGorevListItemDto>>().ReverseMap();
    }
}