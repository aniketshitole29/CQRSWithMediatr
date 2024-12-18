﻿using DataAccess.Model;
using DataAccess.Queries;
using DemoLibrary.Commandas;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<PersonModel> Get(int id)
        {
            return await _mediator.Send(new GetPersonByIdQuery(id));
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<PersonModel> Post([FromBody] PersonModel value)
        {
            var model = new InsertPersonCommand(value.FirstName, value.LastName);
            return await _mediator.Send(model);
        }

        // PUT api/<PersonController>/5
        [HttpPut]
        public async Task<PersonModel> Put([FromBody] PersonModel value)
        {
            return await _mediator.Send(new UpdatePersonCommand(value));
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _mediator.Send(new DeletePersonByIdCommand(id));
        }
    }
}
