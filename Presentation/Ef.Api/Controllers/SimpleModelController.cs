using Ef.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Ef.Api.Controllers
{
    [RoutePrefix("api/home")]
    public class SimpleModelController : ApiController
    {
        private readonly ISimpleModelService _simpleModelService;

        public SimpleModelController(ISimpleModelService simpleModelService)
        {
            _simpleModelService = simpleModelService;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(_simpleModelService.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            return Ok(_simpleModelService.GetById(id));
        }
    }
}