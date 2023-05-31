using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Filter;

namespace WebAPI.Controllers
{
    [ApiController]
    [ApiExceptionFilter]
    [Route("api/v1/[controller]")]
    public class ApiControllerBase : ControllerBase
    {
        private ISender? _mediator;

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
