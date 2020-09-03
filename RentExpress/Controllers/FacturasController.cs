using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Modelo.Dtos;
using Modelo.Dtos.Facturas;
using Modelo.Entidades;
using RentExpress.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentExpress.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {

        private readonly IFacturasServices _services;

        public FacturasController(IFacturasServices services)
        {
            _services = services;
        }

        [HttpGet("facturas")]
        public IQueryable<FacturaCabecera> GetF() => _services.GetFacturaCabeceras();

    }
}
