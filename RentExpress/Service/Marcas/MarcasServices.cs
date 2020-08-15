using System.Collections.Generic;
using AutoMapper;
using Modelo.Dtos;
using RentExpress.ApplicationContex;

namespace RentExpress.Service
{
    public class MarcasServices : IMarcaServices
    {
        private readonly ApplicationDbContex _services;
        private readonly IMapper _mapper;

        public MarcasServices(ApplicationDbContex services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }
        public IEnumerable<MarcasDto> GetAllMarcas()
        {
            var model = _services.Marcas;
            return _mapper.Map<IEnumerable<MarcasDto>>(model);
        }
    }
}
