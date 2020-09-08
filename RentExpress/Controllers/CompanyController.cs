using System.Collections.Generic;
using GenericReport.Service.Company;
using Microsoft.AspNetCore.Mvc;
using Modelo.Dtos.Company;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenericReport.Controllers
{
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private readonly ICompanyServices _service;
        public CompanyController( ICompanyServices service)
        {
            _service = service;

        }
        [HttpGet("companies")]
        public IEnumerable<CompanyDto> Get() => _service.GetAll();


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var model = _service.GetById(id);
            if (model == null) return NotFound();
            return Ok(model);
        }

        [HttpPost("companies")]
        public ActionResult Save([FromBody] CompanyDto model)
        {
          if (!ModelState.IsValid) return BadRequest();

            var result = _service.Post(model);
            return Ok(result);
        }

        [HttpPut("companies")]
        public ActionResult Put([FromBody] CompanyDto model)
        {
            if (!ModelState.IsValid) return BadRequest();

            var result = _service.Put(model);
            return Ok(result);
        }
    }
}
