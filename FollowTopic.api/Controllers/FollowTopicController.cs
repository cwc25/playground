using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FollowTopic.api.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FollowTopic.api.Controllers
{
    [Produces("application/json")]
    [Route("api/FollowTopic")]
    public class FollowTopicController : Controller
    {
        private readonly IMediator _mediator;

        public FollowTopicController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

      
        // POST: api/FollowTopic/follow
        [Route("Follow")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]FollowCommand command) //[FromHeader(Name = "x-requestid")] string requestId)?
        {
            bool commandResult = false;
            commandResult = await _mediator.Send(command);

            return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();
        }
       
    }
}
