using System.Linq;
using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using RentExpress.ApplicationContex;

namespace RentExpress.Service
{
    public class FacturaServices : IFacturasServices
    {
        private readonly ApplicationDbContex _services;
        private readonly IMapper _mapper;

        public FacturaServices(ApplicationDbContex services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }
      
        public IQueryable<FacturaCabecera> GetFacturaCabeceras()
        {

            StringBuilder sb = new StringBuilder();            sb.Append("select * from \"Viw_cabecera_factura\"").ToString();          var result =   _services.FacturaCabecera.FromSqlRaw(sb.ToString());

            return(IQueryable<FacturaCabecera>) result;

         
        }
    }
}
