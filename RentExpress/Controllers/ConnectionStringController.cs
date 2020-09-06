using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericReport.Service.ConnectionString;
using Microsoft.AspNetCore.Mvc;
using Modelo.Abstracts;
using Modelo.Dtos.ConnectionStrings;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenericReport.Controllers
{
    [Route("api/[controller]")]
    public class ConnectionStringController : Controller
    {

        private readonly IConnectionstringServices _services;
        public ConnectionStringController(IConnectionstringServices services)
        {
            _services = services;

        }

        [HttpGet ("connections")]
        public IEnumerable<ConnectionStringDto> GetAll()
        {
            return _services.GetAll();
        }


        [HttpGet("{Id}")]
        public ActionResult<ConnectionStringDto> Get(int Id)
        {
            var model =  _services.GetByid(Id);
            if (model == null) return NotFound();
            return Ok(model);
        }


        [HttpPost("connection")]
        public ActionResult Save([FromBody] ConnectionStringDto model)
        {
            if (!ModelState.IsValid)  return BadRequest();

           var result =  _services.Post(model);

            return Ok(result);

        }
    }
}
