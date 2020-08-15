using AutoMapper;
using Modelo;
using Modelo.Dtos;
using Modelo.Entidades;

namespace RentExpress.Profiles
{
    public class GeneralProfile :Profile
    {
        public GeneralProfile()
        {
            CreateMap<Personas, PersonaDto>().ReverseMap();
            CreateMap<Roles, RolesDto>().ReverseMap();
            CreateMap<Marcas, MarcasDto>().ReverseMap();
        }
    }
}
