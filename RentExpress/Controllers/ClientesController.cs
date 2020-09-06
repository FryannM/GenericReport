using System.Collections.Generic;
using GenericReport.Service.Clientes;
using Microsoft.AspNetCore.Mvc;
using Modelo.Dtos.Clientes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenericReport.Controllers
{
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        private readonly IClientesServices _services;
        public ClientesController(IClientesServices services)
        {
            _services = services;

        }

        // GET: api/values
        [HttpGet("clientes")]
        public IEnumerable<ClientesDto> Get() => _services.GetAll();
        

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var model = _services.GetById(id);
            if (model == null) return NotFound();
            return Ok(model);
        }

        [HttpPost("clientes")]
        public ActionResult Save([FromBody] ClientesSaveDto model)
        {
            if (!ModelState.IsValid) return BadRequest();

            var result = _services.Post(model);

            return Ok(result);

        }

    }
}
