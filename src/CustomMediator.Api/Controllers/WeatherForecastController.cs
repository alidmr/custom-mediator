using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CustomMediator.Api.Command;
using CustomMediator.Api.Query;
using CustomMediator.Library.Interfaces;

namespace CustomMediator.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<UserViewModel> Get()
        {
            var result = _mediator.Send(new GetUserByIdQuery(10));

            return result;
        }

        [HttpPut]
        public Task<int> Update()
        {
            var result = _mediator.Send(new UpdateNameCommand("Ahmet"));

            return result;
        }
    }
}