using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace OrionInnovationApi.Controllers
{
    public class BaseController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator MediatR => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}