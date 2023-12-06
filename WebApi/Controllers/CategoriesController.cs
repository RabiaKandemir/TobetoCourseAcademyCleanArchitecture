using Application.Features.Categories.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            CreatedCategoryResponse response = await _mediator.Send(createCategoryCommand);
            return Ok(response);
        }
    }
}
