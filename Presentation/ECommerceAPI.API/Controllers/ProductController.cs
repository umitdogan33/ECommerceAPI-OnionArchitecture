using ECommerceAPI.Application.CQRS.Commands.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add()
        {
            CreateProductCommandRequest deneme = new("adana",4,2);
        var response =await _mediator.Send(deneme);
            return Ok(response.IsSuccess);
        }
    }
}
