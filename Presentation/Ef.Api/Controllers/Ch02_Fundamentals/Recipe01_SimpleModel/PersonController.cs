using AutoMapper;
using Ef.Api.Models;
using Ef.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Ef.Api.Controllers
{
    [RoutePrefix("api/people")]
    public class PersonController : ApiController
    {
        private readonly ISimpleModelService _simpleModelService;

        public PersonController(ISimpleModelService simpleModelService)
        {
            _simpleModelService = simpleModelService;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult List()
        {
            var peopleFromDb = _simpleModelService.GetAll();

            var peopleDto = Mapper.Map<IEnumerable<PersonDto>>(peopleFromDb);

            return Ok(peopleDto);
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            var personFromDb = _simpleModelService.GetById(id);

            var personDto = Mapper.Map<PersonDto>(personFromDb);

            return Ok(personDto);
        }


    }
}