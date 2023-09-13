using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Suffolk.Core.Models;
using MediatR;
using Suffolk.Core.Queries;

namespace Suffolk.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IMediator _mediator;
        public PersonController(IMediator mediator ) 
        {
            _mediator = mediator;
        }

        [HttpGet("GetPeople")]
        public async  Task<ActionResult<List<Person>>> GetPeoples()
        {
           var people = await _mediator.Send(new GetPersonListQuery());
            return Ok(people);
        }

        [HttpGet("GetPersonById")]
        public async Task<ActionResult<Person>> GetPersonById(string id)
        {
            return Ok(await _mediator.Send(new GetPersonByIdQuery(id)));
        }
    }
}
