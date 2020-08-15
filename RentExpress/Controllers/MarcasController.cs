using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Modelo.Dtos;
using RentExpress.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentExpress.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {

        private readonly IMarcaServices _services;

        public MarcasController(IMarcaServices services)
        {
            _services = services;
        }

        [HttpGet("marcas")]
        public IEnumerable<MarcasDto> Get() => _services.GetAllMarcas();
      
    }
}
