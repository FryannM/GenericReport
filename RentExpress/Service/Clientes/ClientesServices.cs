using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GenericReport.ApplicationContex;
using Modelo.Dtos.Clientes;

namespace GenericReport.Service.Clientes
{
    public class ClientesServices : IClientesServices
    {
        private readonly SqlDbContext _services;
        private readonly IMapper _mapper;
        public ClientesServices( SqlDbContext services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }

        public IEnumerable<ClientesDto> GetAll()
        {
            var model = _services.Clientes.AsEnumerable();
            return _mapper.Map<IEnumerable<ClientesDto>>(model);
        }
    }
}
