using Application.Features.Gorevs.Commands.Create;
using Application.Features.Gorevs.Commands.Delete;
using Application.Features.Gorevs.Commands.Update;
using Application.Features.Gorevs.Queries.GetById;
using Application.Features.Gorevs.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GorevsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateGorevCommand createGorevCommand)
    {
        CreatedGorevResponse response = await Mediator.Send(createGorevCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateGorevCommand updateGorevCommand)
    {
        UpdatedGorevResponse response = await Mediator.Send(updateGorevCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedGorevResponse response = await Mediator.Send(new DeleteGorevCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdGorevResponse response = await Mediator.Send(new GetByIdGorevQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListGorevQuery getListGorevQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListGorevListItemDto> response = await Mediator.Send(getListGorevQuery);
        return Ok(response);
    }
}