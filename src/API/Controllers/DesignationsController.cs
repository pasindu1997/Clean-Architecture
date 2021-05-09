using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boomerang.Employee.Application.Designations.Commands.CreateDesignation;
using Boomerang.Employee.Application.Designations.Queries.GetDesignations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Boomerang.Employee.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class DesignationsController : ApiController
    {
        // GET: api/Designations
        [HttpGet]
        public async Task<ActionResult<List<DesignationDto>>> Get()
        {
            return await Mediator.Send(new GetDesignationsQuery());
        }

        // GET: api/Designations/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateDesignationCommand command)
        {
            return await Mediator.Send(command);
        }

        // PUT: api/Designations/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
