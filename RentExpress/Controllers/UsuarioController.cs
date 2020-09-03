using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericReport.Service.User;
using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenericReport.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioServices _services;

      
        public UsuarioController( IUsuarioServices services)
        {
            _services = services;
        }
        // GET: api/values
        [HttpGet("usuarios")]
        public IEnumerable<Usuarios> Get()
        {
          return  _services.GetUsuarios();
        }

       
    }
}
