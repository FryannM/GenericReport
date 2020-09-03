using AutoMapper;
using Modelo.Dtos.Facturas;

namespace RentExpress.Profiles
{
    public class GeneralProfile :Profile
    {
        public GeneralProfile()
        {
            CreateMap<FacturaCabeceraDto, FacturaCabeceraDto>().ReverseMap();
        }
    }
}
