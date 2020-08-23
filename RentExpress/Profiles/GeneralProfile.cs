using AutoMapper;
using Modelo.Dtos;
using Modelo.Dtos.Facturas;
using Modelo.Entidades;

namespace RentExpress.Profiles
{
    public class GeneralProfile :Profile
    {
        public GeneralProfile()
        {

            CreateMap<Roles, RolesDto>().ReverseMap();
            CreateMap<FacturaCabeceraDto, FacturaCabeceraDto>().ReverseMap();

        }
    }
}
