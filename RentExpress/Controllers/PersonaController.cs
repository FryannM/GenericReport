using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Abstracts;
using Modelo.Dtos;
using Services;


namespace RentExpress.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaServices _services;
        public PersonaController(IPersonaServices services)
        {
            _services = services;

        }
        
        [HttpGet("personas")]
        public IEnumerable<PersonaDto> Get() => _services.GetAllPersonas();



        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("persona")]
        public IActionResult Save([FromBody]PersonaDto model) =>  Ok(_services.Save(model));

      

        [HttpPut("persona")]
        public IActionResult Update([FromBody]PersonaDto model)
        {
            var result = _services.GetPersonaById(model.Id);
               if (result == null) return NotFound();

            return Ok(_services.Update(model));
        }
    }
}
